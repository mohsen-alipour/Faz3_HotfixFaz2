using System.ComponentModel.DataAnnotations;

namespace App.EndPoint.UI.Areas.Admin.Models.ViewModels.BaseData
{
    public class OrderViewModel
    {
        [Display(Name = "عنوان سرویس")]
        public string ServiceTitle { get; set; }

        [Display(Name = "شناسه مشتری")]
        public string CustomerUserName { get; set; }

        [Display(Name = "قیمت پایه")]
        public int BasePrice { get; set; }

        [Display(Name = "قیمت نهایی")]
        public int TotalPrice { get; set; }

        [Display(Name = "تاریخ سفارش")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "وضعیت")]
        public string StatusTitle { get; set; }

        [Display(Name = "شناسه کارشناس")]
        public string FainalExpertUserName { get; set; }

       

       

     

    


    }
}
