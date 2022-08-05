using App.Domain.Core.Account.Contacts.AppService;
using App.Domain.Core.Account.Contacts.Service;
using App.Domain.Core.Account.Dtos;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Account
{
    public class UserAppService : IUserAppService
    {
        private readonly IUserService _userService;

        public UserAppService(IUserService userService)
        {
            _userService = userService;
        }

        public async Task Add(UserDto UserDto)
        {
            await _userService.Add(UserDto);
        }

        async Task<IdentityResult> IUserAppService.Add(UserDto UserDto)
        {
            return await _userService.Add(UserDto);
        }

        public async Task Delete(int Id)
        {
            await _userService.Delete(Id);
        }

        public async Task<UserDto> Get(int id)
        {
            return await _userService.Get(id);
        }

        public async Task<List<UserDto>> GetAll()
        {
            return await _userService.GetAll();
        }

        public async Task Update(UserDto UserDto)
        {
            await _userService.Update(UserDto);
        }

       
    }  
}
