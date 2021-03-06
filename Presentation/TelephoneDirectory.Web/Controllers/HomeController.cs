using MassTransit;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using PhoneBook.Libraries.Core;
using PhoneBook.Web.Models;
using PhoneBook.Web.Models.Report;
using PhoneBook.Web.Services;

namespace PhoneBook.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IReportService _reportService;
        private readonly IUserService _userService;
        private readonly IContactService _contactService;
        private readonly ISendEndpointProvider _sendEndpointProvider;
        public HomeController(IReportService reportService, ISendEndpointProvider sendEndpointProvider, IUserService userService, IContactService contactService)
        {
            _reportService = reportService;
            _sendEndpointProvider = sendEndpointProvider;
            _userService = userService;
            _contactService = contactService;
        }


        public async Task<IActionResult> Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel();
           var userData = await _userService.GetAllAsync();
            if(userData != null) homeViewModel.userList = userData; 
           var reportData = await _reportService.GetAllAsync();
            if(reportData != null)homeViewModel.reportList = reportData;
           var contactData = await _contactService.GetAllAsync();
            if(contactData !=null) homeViewModel.contactList = contactData;
          
            return View(homeViewModel);
        }


        public async Task<IActionResult> CreateReport(ReportCreateInput reportCreateInput)
        {
            var sendEndpoint = await _sendEndpointProvider.GetSendEndpoint(new Uri("queue:create-report-service"));
            reportCreateInput.ReportStatus = false;
            reportCreateInput.RequestTime = DateTime.Now;
            reportCreateInput.TotalPhone = 0;
            reportCreateInput.TotalUser = 0;
            reportCreateInput.Deleted = false;
            var responseCreateReport = await _reportService.CreateAsync(reportCreateInput);
            CreateReportMessageCommand report = new CreateReportMessageCommand();
            report.Location = responseCreateReport.Location;
            report.ReportId = responseCreateReport.Id;
            await sendEndpoint.Send<CreateReportMessageCommand>(report);
            return RedirectToAction("Index");
        }

    }
}
