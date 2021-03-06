using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PhoneBook.Libraries.Core;

namespace PhoneBook.Libraries.Services
{
    public interface IUserService
    {
        Task<Response<List<UserDto>>> GetAllAsync();
        Task<Response<UserDto>> CreateAsync(UserDto UserDto);
        Task<Response<UserDto>> GetByIdAsync(string id);
        Task<Response<NoContent>> DeleteAsync(string id);

    }
}
