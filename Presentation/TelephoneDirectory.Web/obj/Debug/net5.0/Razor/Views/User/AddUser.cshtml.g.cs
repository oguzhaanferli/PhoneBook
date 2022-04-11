#pragma checksum "C:\Users\Zafer\Documents\Projects\TelephoneDirectory\Presentation\TelephoneDirectory.Web\Views\User\AddUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3847210e099291949025a3d51cb6ef3dd684b4ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_AddUser), @"mvc.1.0.view", @"/Views/User/AddUser.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3847210e099291949025a3d51cb6ef3dd684b4ad", @"/Views/User/AddUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_AddUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TelephoneDirectory.Web.Models.User.UserCreateInput>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-8 order-md-1"">
        <h4 class=""mb-3"">Add User Form</h4>
        <form class=""needs-validation"" method=""post"" asp-controller=""User"" asp-action=""AddUser"">
            <div class=""row"">
                <div class=""col-md-6 mb-3"">
                    <label for=""firstName"">First name</label>
                    <input type=""text"" class=""form-control"" asp-for=""Name"" name=""Name""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 485, "\"", 499, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 500, "\"", 508, 0);
            EndWriteAttribute();
            BeginWriteAttribute("required", " required=\"", 509, "\"", 520, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""invalid-feedback"">
                        Valid first name is required.
                    </div>
                </div>
                <div class=""col-md-6 mb-3"">
                    <label for=""lastName"">Last name</label>
                    <input type=""text"" class=""form-control"" asp-for=""Surname"" name=""Surname""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 881, "\"", 895, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 896, "\"", 904, 0);
            EndWriteAttribute();
            BeginWriteAttribute("required", " required=\"", 905, "\"", 916, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""invalid-feedback"">
                        Valid last name is required.
                    </div>
                </div>
            </div>

            <div class=""mb-3"">
                <label for=""address"">Company</label>
                <input type=""text"" class=""form-control"" asp-for=""Company"" name=""Company""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1274, "\"", 1288, 0);
            EndWriteAttribute();
            BeginWriteAttribute("required", " required=\"", 1289, "\"", 1300, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""invalid-feedback"">
                    Please enter your company.
                </div>
            </div>

            <hr class=""mb-4"">
            <button class=""btn btn-primary btn-lg btn-block"" type=""submit"">Save</button>
        </form>
    </div>
</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TelephoneDirectory.Web.Models.User.UserCreateInput> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591