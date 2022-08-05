using App.Domain.Core.BaseData.Entity;
using App.EndPoint.UI.Areas.Admin.Models.ViewModels.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.EndPoint.UI.Areas.Admin.Controllers
{
    //[Authorize(Roles = "AdminRole")]
    public class DashboardController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public DashboardController(UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
      
        public async Task<IActionResult> UserList()
        {
            var model = await _userManager.Users.Select(x=>new Use_Mviewmodel
            {
                Id = x.Id,
                UserName = x.UserName,
                FirstName = x.FirstName,
                LastName=x.LastName,
                PhoneNumber = x.PhoneNumber,
                Isactive=x.Isactive,
                CreatedAt=x.CreatedAt,
               
            }).ToListAsync();

            return View(model);
        }
        //[HttpGet]
        //public async Task<IActionResult> RegisterUser()
        //{

        //    return View();
        //}
        //[HttpPost]
        //public async Task<IActionResult> RegisterUser(Usermanagmentviewmodel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = new AppUser
        //        {
                  
        //           FirstName = model.FirstName,
        //           LastName=model.LastName,
        //           UserName = model.UserName,
        //           Isactive=model.Isactive,
        //           PhoneNumber=model.PhoneNumber,
        //           CreatedAt = DateTime.Now,
                   
                   
        //        };

        //        var result = await _userManager.CreateAsync(user, model.Password);
        //        if (result.Succeeded)
        //        {
        //            //await _userManager.AddToRoleAsync(user, "CustomerRole");
        //            await _signInManager.SignInAsync(user, isPersistent: false);
        //            return RedirectToAction("UserList");
        //        }
        //        else
        //        {
        //            foreach (var item in result.Errors)
        //            {
        //                ModelState.AddModelError(string.Empty, item.Description);
        //            }
        //        }
        //    }
        //    return View(model);

           
        //}


        public async Task<IActionResult> Delete(int id)
        {
            var user = _userManager.Users.FirstOrDefault(u => u.Id == id);
            var result = await _userManager.DeleteAsync(user);
            
            return RedirectToAction("UserList");
        }
        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            var user = _userManager.Users.FirstOrDefault(u => u.Id == id);
            Use_Mviewmodel u = new Use_Mviewmodel();
            u.FirstName = user.FirstName;
            u.LastName = user.LastName;
            u.PhoneNumber = user.PhoneNumber;
            u.UserName = user.UserName;
            u.Isactive = user.Isactive;
            return View(u);                 
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var user = _userManager.Users.FirstOrDefault(u => u.Id == id);
            Use_Mviewmodel x = new Use_Mviewmodel();
            x.FirstName = user.FirstName;
            x.LastName = user.LastName;
            x.PhoneNumber = user.PhoneNumber;
            x.UserName = user.UserName;
            x.Isactive = user.Isactive;
            return View(x);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(Use_Mviewmodel userVmodel)
        {


            var user = _userManager.Users.FirstOrDefault(u => u.Id == userVmodel.Id);
            user.FirstName=userVmodel.FirstName;
            user.LastName=userVmodel.LastName;
            user.UserName=userVmodel.UserName;
            user.Isactive = userVmodel.Isactive;
            user.PhoneNumber = userVmodel.PhoneNumber;

            await _userManager.UpdateAsync(user);       
            return RedirectToAction("UserList");
        }
    }

    

}
