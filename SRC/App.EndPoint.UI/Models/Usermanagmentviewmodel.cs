
using System.ComponentModel.DataAnnotations;

namespace App.EndPoint.UI.Models
{
    public class Usermanagmentviewmodel
    {
        public int Id { get; set; }
        [Display(Name = "نام")]
        public string FirstName { get; set; }
        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "شناسه کاربری الزامی است")]
        [Display(Name = "شناسه کاربری")]
        public string UserName { get; set; }
        [Display(Name = "وضعیت کاربر")]
        public bool Isactive { get; set; }
        [Display(Name = "شماره تلفن"),]
        [Required(ErrorMessage = "شماره تلفن الزامی است")]
        public string PhoneNumber { get; set; }
        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "تکرار رمز عبور")]
        [Compare(nameof(Password), ErrorMessage = "رمز عبور و تکرار رمز عبور باید یکسان باشند")]
        public string ConfirmPassword { get; set; }

    }
}
