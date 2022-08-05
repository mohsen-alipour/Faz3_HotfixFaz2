
using System.ComponentModel.DataAnnotations;

namespace App.EndPoint.UI.Areas.Admin.Models.ViewModels.Account
{
    public class Use_Mviewmodel
    {
        public int Id { get; set; }
        [Display(Name = "نام")]
        public string FirstName { get; set; }
        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }
        [Display(Name = "شناسه کاربری")]
        public string UserName { get; set; }
        [Display(Name = "وضعیت کاربر")]
        public bool Isactive { get; set; }
        [Display(Name = "شماره تلفن")]
        public string PhoneNumber { get; set; }
        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

    }
}
