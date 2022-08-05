using System.ComponentModel.DataAnnotations;

namespace App.EndPoint.UI.Areas.Admin.Models.ViewModels.BaseData
{
    public class OutputCategoryViewModel
    {
        [Display(Name = "شناسه سرویس")]
        public int Id { get; set; }
        [Display(Name = "عنوان")]
        public string Title { get; set; }
    }
}
