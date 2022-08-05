using App.Domain.Core.Account.Contacts.Repositories;
using App.Domain.Core.Account.Contacts.Service;
using App.Domain.Core.Account.Dtos;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.Account
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        //public async Task Add(UserDto UserDto)
        //{
        //    await _userRepository.Add(UserDto);
        //}

        public async Task<IdentityResult> Add(UserDto UserDto)
        {
            return await _userRepository.Add(UserDto);
        }

        public async Task Delete(int Id)
        {
            await _userRepository.Delete(Id);
        }

        public async Task<UserDto> Get(int id)
        {
            return await _userRepository.Get(id);
        }

        public async Task<List<UserDto>> GetAll()
        {
            return await _userRepository.GetAll();
        }

        public async Task Update(UserDto UserDto)
        {
            await _userRepository.Update(UserDto);
        }

      
    }
}
