using System.ComponentModel.DataAnnotations;

namespace App.EndPoint.UI.Models
{
    public class ListOrderViewModel
    {
        [Display(Name = "شناسه سرویس")]
        public int Id { get; set; }
        [Display(Name = "عنوان سرویس")]
        public string ServiceTitle { get; set; }
        [Display(Name = "تاریخ درخواست")]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "کارشناس")]
        public int? FainalExpert { get; set; }
        [Display(Name = "قیمت پایه")]
        public int Price { get; set; }
        [Display(Name = "وضعیت درخواست")]
        public string statustitle { get; set; }
    }
}
