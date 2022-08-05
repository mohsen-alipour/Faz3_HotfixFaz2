using App.Domain.Core.Account.Contacts.AppService;
using App.Domain.Core.Account.Dtos;
using App.Domain.Core.BaseData.Entity;
using App.EndPoint.UI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoint.UI.Controllers
{
    public class AccountController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IUserAppService _userAppService;

        public AccountController(
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            IUserAppService userAppService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userAppService = userAppService;
        }
        public async Task<IActionResult> Error()
        {

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, false);
           
                if (result.Succeeded)
                {
                    var currentUser = await _userManager.FindByNameAsync(model.Username);
                    var x = await _userManager.GetRolesAsync(currentUser);

                    if (x[0] == "CustomerRole")
                    {
                        return RedirectToAction("CustomerIndex", "Home");
                    }
                    if (x[0] == "AdminRole")
                    {
                        return RedirectToAction("Index", "AdminDashboard", new { area = "Admin"});
                    }

                }

                ModelState.AddModelError(string.Empty, "خطا در فرآیند لاگین");
            }
            return RedirectToAction("Index","Home");
        }

        [HttpGet]
        public async Task<IActionResult> RegisterUser()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RegisterUser(Usermanagmentviewmodel model)
        {
            if (ModelState.IsValid)
            {
                var AvailableUser = _userManager.Users.FirstOrDefault(u => u.UserName == model.UserName);
                if(AvailableUser == null)
                {

                    var user = new AppUser
                    {
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        UserName = model.UserName,
                        PhoneNumber = model.PhoneNumber,
                        CreatedAt = DateTime.Now,

                    };
                    var User1 = new UserDto
                    {

                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        UserName = model.UserName,
                        PhoneNumber = model.PhoneNumber,
                        CreatedAt = DateTime.Now,
                        Password = model.Password,

                    };

                    // var result = await _userAppService.Add(User1);
                    //Before use AppService
                    var result = await _userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {

                        //await _userManager.AddToRoleAsync(user, "CustomerRole");

                        //var User = await _userManager.FindByNameAsync("admin");
                        var addRole = await _userManager.AddToRoleAsync(user, "CustomerRole");

                        //چرا کار نمی کنه
                        //await _signInManager.SignInAsync(user,false);

                        //return RedirectToAction("index", "Home", new {areas="Dasho"})
                        return RedirectToAction("CustomerIndex", "Home");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, item.Description);
                        }

                    }


                }

                return RedirectToAction("Error", "Account");

            }
            return View(model);
           // return RedirectToAction("RegisterUser", "Account");
        }

    }


   
}
