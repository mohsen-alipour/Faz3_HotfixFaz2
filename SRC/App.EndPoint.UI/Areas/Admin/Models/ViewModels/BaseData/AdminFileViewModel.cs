using System.ComponentModel.DataAnnotations;

namespace App.EndPoint.UI.Areas.Admin.Models.ViewModels.BaseData
{
    public class AdminFileViewModel
    {
        [Display(Name = "شناسه سرویس")]
        public int Id { get; set; }
        [Display(Name = "عنوان سرویس")]
        public string ServiceTitle { get; set; }
        [Display(Name = "شناسه مشتری سفارش دهنده")]
        public int CustomerUserId { get; set; }
        public IFormFile FormFile { get; set; }

        [Display(Name = "نام فایل")]
        public string FileNme { get; set; } = null;

        [Display(Name = "تاریخ بارگذاری")]
        public DateTime CreatedAt { get; set; }
    }
}
