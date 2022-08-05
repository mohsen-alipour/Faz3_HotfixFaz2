using App.Domain.Core.BaseData.Contacts.AppService;
using App.Domain.Core.BaseData.Dtos;
using App.Domain.Core.BaseData.Entity;
using App.Domain.Core.Customer.Contacts.AppService;
using App.Domain.Core.Customer.Dtos;
using App.EndPoint.UI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace App.EndPoint.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServiceAppService _serviceAppService;
        private readonly IOrderAppService _orderAppService;
        private readonly IAppFileAppService _appFileAppService;
        private readonly UserManager<AppUser> _userManager;  
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public HomeController(ILogger<HomeController> logger,
                IServiceAppService serviceAppService,
                IOrderAppService orderAppService,
                IAppFileAppService appFileAppService,
                UserManager<AppUser> userManager,
                RoleManager<IdentityRole<int>> roleManager)
        {
            _logger = logger;
            _serviceAppService = serviceAppService;
            _orderAppService = orderAppService;
            _appFileAppService = appFileAppService;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult CustomerIndex()
        {
            return View();
        }
    


        /// <summary>
        /// حذف یک سفارش بر اساس آی دی 
        /// </summary>
        /// <param name="id">شناسه سفارش</param>
        /// <returns></returns>
        public async Task<IActionResult> DeleteOrder(int id)
        {
            _logger.LogTrace("start metod {me}", "DeleteOrder");
            await _orderAppService.Delete(id);
            _logger.LogTrace("finish{method}" , "DeleteOrder");
            if(id== 0)
            {
                _logger.LogWarning("some thing is wrong order is zero");
            }
            else
            {
                _logger.LogDebug("orderID is{ID}",id);
            }
            return RedirectToAction("HistoryOrder");
        }    
      
        public async Task<IActionResult> SabtOrder(int id)
        {
            var record = await _serviceAppService.Get(id);

            var dto = new OrderDto
            {
                StatusId = 1,
                Serviceid = record.Id,
                ServiceBasePrice = record.Price,             
                CreatedAt = DateTime.Now,          

            };
            
            await _orderAppService.Add(dto);

            _logger.LogInformation("sabt order");

            return RedirectToAction("HistoryOrder");
        }
     
        public async Task<IActionResult> HistoryOrder(CancellationToken cancellationToken)
        {
            var record = await _orderAppService.GetAll(cancellationToken);

            var RC = record.Select(x => new ListOrderViewModel
            {
                Id = x.Id,
                ServiceTitle=x.Servicetitle,
                CreatedAt=x.CreatedAt,
                FainalExpert=x.FainalExpertUserid,
                Price=x.ServiceBasePrice,
                statustitle=x.Statustitle,
            }).ToList();

            return View(RC);
        }

        public async Task<IActionResult> ListService(CancellationToken cancellationToken)
        {
            var record = await _serviceAppService.GetAll(cancellationToken);
            var RC = record.Select(x => new ListServiceViewModel
            {
                Id = x.Id,
                CategoryTitle = x.CategoryTitle,
                Title = x.Title,
                Price = x.Price,
                ShortDescription = x.ShortDescription,
            }).ToList();

            return View(RC);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        #region FileManager
        /// <summary>
        /// آپلود فایل در سبد خرید
        /// </summary>
        /// <param name="id"></param>
        [HttpGet]
        public async Task<IActionResult> FileUpload(int Id)
        {

            var Record = await _orderAppService.Get(Id);
            FileViewModel V = new FileViewModel();
            V.Id = Record.Id;
            V.ServiceTitle = Record.Servicetitle;           
            V.CustomerUserId = Record.CustomerUserId;
            return View(V);
        }
        [HttpPost]
        public async Task<IActionResult> FileUpload(FileViewModel ModelFile)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(ModelFile);
            //}
            var dto = new AppFileDto
            {        
                CreatedUserId = ModelFile.CustomerUserId,
                FileNme = ModelFile.FormFile.FileName,
            };
            await _appFileAppService.Add(dto);

            string SavePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Media", ModelFile.FormFile.FileName);
            using (var stream = new FileStream(SavePath, FileMode.Create))
            {
                ModelFile.FormFile.CopyTo(stream);
            }
            //var dto2 = new OrderFileDto
            //{
            //    OrderId = ModelFile.Id,
            //    CreatedUserId = ModelFile.CustomerUserId,

            //};


            return RedirectToAction("HistoryOrder");
        }
        #endregion FileManager



        public async Task<IActionResult> UploadFile(int id)
        {
            var record = await _serviceAppService.Get(id);

            var dto = new OrderDto
            {
                StatusId = 1,
                Serviceid = record.Id,
                ServiceBasePrice = record.Price,
                CreatedAt = DateTime.Now,

            };

            await _orderAppService.Add(dto);

            _logger.LogInformation("sabt order");

            return RedirectToAction("HistoryOrder");
        }



        //[HttpPost]
        //public async Task<IActionResult> Order(ListServiceViewModel model)
        //{
        //    var dto = new OrderDto
        //    {
        //        ServiceBasePrice=model.Price,
        //        CreatedAt=DateTime.Now,
        //        Serviceid=model.Id,
        //        StatusId=1,

        //    };
        //    await _orderAppService.Add(dto);

        //    return View();
        //}

        //public async Task<IActionResult> SeedData()

        //{
        //var adminCroleCreation = await _roleManager.CreateAsync(new IdentityRole<int>("AdminRole"));
        //var customerCroleCreation = await _roleManager.CreateAsync(new IdentityRole<int>("CustomerRole"));
        //var expertrole = await _roleManager.CreateAsync(new IdentityRole<int>("ExpertRole"));


        //var adminResult = await _userManager.CreateAsync(new AppUser("admin"), "1234567");
        //if (adminResult.Succeeded)
        //{
        //    var adminUser = await _userManager.FindByNameAsync("admin");
        //    var addAdminRole = await _userManager.AddToRoleAsync(adminUser, "AdminRole");
        //}

        //var customer1Result = await _userManager.CreateAsync(new AppUser("cutomer1"), "1234567");
        //if (customer1Result.Succeeded)
        //{
        //    var customer1User = await _userManager.FindByNameAsync("cutomer1");
        //    var addCustomerRole = await _userManager.AddToRoleAsync(customer1User, "CustomerRole");
        //}
        //return Ok();
        //}

    }
}