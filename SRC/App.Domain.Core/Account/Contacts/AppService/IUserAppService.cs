using App.Domain.Core.Account.Dtos;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Account.Contacts.AppService
{
    public interface IUserAppService
    {
        Task <IdentityResult> Add(UserDto UserDto);
        //Task  Add(UserDto UserDto);
        Task<List<UserDto>> GetAll();
        Task<UserDto> Get(int id);
        Task Update(UserDto UserDto);
        Task Delete(int Id);
    }
}
