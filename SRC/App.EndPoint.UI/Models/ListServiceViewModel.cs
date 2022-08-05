using System.ComponentModel.DataAnnotations;

namespace App.EndPoint.UI.Models
{
    public class ListServiceViewModel
    {
        [Display(Name = "شناسه سرویس")]
        public int Id { get; set; }
        [Display(Name = "دسته بندی خدمات")]
        public string CategoryTitle { get; set; }
        [Display(Name = "عنوان سرویس")]
        public string Title { get; set; } = null!;
        [Display(Name = "توضیحات")]
        public string? ShortDescription { get; set; }
        [Display(Name = "قیمت پایه")]
        public int Price { get; set; }
        public int categuryid { get; set; }
    }
}
