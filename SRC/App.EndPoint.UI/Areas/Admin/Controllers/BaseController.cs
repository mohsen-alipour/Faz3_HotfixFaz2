using App.Domain.Core.BaseData.Contacts.AppService;
using App.Domain.Core.BaseData.Dtos;
using App.Domain.Core.Customer.Contacts.AppService;
using App.EndPoint.UI.Areas.Admin.Models.ViewModels.BaseData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace App.EndPoint.UI.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        private readonly ICateguryAppService _categuryAppService;
        private readonly IServiceAppService _serviceAppService;
        private readonly IOrderAppService _orderAppService;
        private readonly IAppFileAppService _appFileAppService;

        public BaseController(ICateguryAppService categuryAppService,
            IServiceAppService serviceAppService,
            IOrderAppService orderAppService,
            IAppFileAppService appFileAppService)
        {
            _categuryAppService = categuryAppService;
            _serviceAppService = serviceAppService;
            _orderAppService = orderAppService;
            _appFileAppService = appFileAppService;
        }
        #region category

        public async Task<IActionResult> GetAllCategory()
        {
            var record = await _categuryAppService.GetAll();
            var RC = record.Select(x => new OutputCategoryViewModel
            {
                Id = x.Id,
                Title = x.Title,
            }).ToList();

            return View(RC);
        }


        [HttpGet]
        public async Task<IActionResult> SetCategory()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SetCategory(OutputCategoryViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var dto = new CategoryDto
            {
                Title = model.Title,
            };
            await _categuryAppService.Add(dto);
            return RedirectToAction("GetAllCategory");
        }


        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _categuryAppService.Delete(id);
            return RedirectToAction("GetAllCategory");
        }
        [HttpGet]
        public async Task<IActionResult> EditCategory(int id)
        {

            var X = await _categuryAppService.Get(id);
            OutputCategoryViewModel C = new OutputCategoryViewModel();

            C.Id = X.Id;
            C.Title = X.Title;
            return View(C);

        }

        [HttpPost]
        public async Task<IActionResult> EditCategory(OutputCategoryViewModel model)
        {
            var dto = new CategoryDto
            {
                Id = model.Id,
                Title = model.Title,
            };
            await _categuryAppService.Update(dto);
            return RedirectToAction("GetAllCategory");

        }
        #endregion category

        #region Service

        public async Task<IActionResult> GetAllService(CancellationToken cancellationToken)
        {
            var record = await _serviceAppService.GetAll(cancellationToken);
            var RC = record.Select(x => new ServiceViewModel
            {
              Id=x.Id,
              CategoryTitle=x.CategoryTitle,
              Title =x.Title,
              Price=x.Price,
              ShortDescription = x.ShortDescription,
            }).ToList();

            return View(RC);
        }

        [HttpGet]
        public async Task<IActionResult> setservice()
        {

            var category = await _categuryAppService.GetAll();
            ViewBag.category = category.Select
            (s => new SelectListItem
            {
                Text = s.Title,
                Value = s.Id.ToString()
            });

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> setservice(ServiceViewModel ModelServive)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(ModelServive);
            //}
            var dto = new ServiceDto
            {
                
                Categoryid= ModelServive.categuryid,
                Title= ModelServive.Title,
                Price= ModelServive.Price,
                ShortDescription= ModelServive.ShortDescription,
            };
            await _serviceAppService.Add(dto);
            return RedirectToAction("GetAllService");
        }
        #endregion Service

        #region Order

        public async Task<IActionResult> GetAllOrder(CancellationToken cancellationToken)
        {
            var record = await _orderAppService.GetAll(cancellationToken);
            var RC = record.Select(x => new OrderViewModel
            {
            ServiceTitle=x.Servicetitle,
            CustomerUserName=x.CustomerUserName,
            BasePrice=x.ServiceBasePrice,
            TotalPrice=x.TotalPrice,
            OrderDate=x.CreatedAt,
            StatusTitle = x.Statustitle,
            FainalExpertUserName = x.FainalExpertUserName
                     
            }).ToList();

            return View(RC);
        }

        #endregion Order

        #region File
        public async Task<IActionResult> GetAllFile()
        {
            var record = await _appFileAppService.GetAll();
            var R = record.Select(x => new AdminFileViewModel
            {
             Id=x.Id,
             CreatedAt=x.CreatedAt,
             FileNme=x.FileNme,
            }).ToList();

            return View(R);
        }
        #endregion File

    }
}
