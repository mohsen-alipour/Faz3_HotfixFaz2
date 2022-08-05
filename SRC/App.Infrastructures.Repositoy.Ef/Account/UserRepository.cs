using App.Domain.Core.Account.Contacts.Repositories;
using App.Domain.Core.Account.Dtos;
using App.Domain.Core.BaseData.Entity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructures.Repositoy.Ef.Account
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<AppUser> _userManager;

        public UserRepository(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> Add(UserDto UserDto)
            {
            var user = new AppUser
            {
               
                FirstName = UserDto.FirstName,
                LastName = UserDto.LastName,
                UserName = UserDto.UserName,
                PhoneNumber = UserDto.PhoneNumber,
                CreatedAt = DateTime.Now,
                //Email = "a@gmail.com",
            };
            //return await _userManager.CreateAsync(user, UserDto.Password);
            var Resul= await _userManager.CreateAsync(user,UserDto.Password);
            return Resul;

        }



        //public async Task Add(UserDto UserDto)

        //{
        //    var user = new AppUser
        //    {
        //        FirstName = UserDto.FirstName,
        //        LastName = UserDto.LastName,
        //        UserName = UserDto.UserName,
        //        PhoneNumber = UserDto.PhoneNumber,
        //        CreatedAt = DateTime.Now,
        //    };
        //    await _userManager.CreateAsync(user, UserDto.Password);
        //}

        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(UserDto UserDto)
        {
            throw new NotImplementedException();
        }

       
    }
}
