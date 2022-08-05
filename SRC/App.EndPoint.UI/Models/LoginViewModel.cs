using System.ComponentModel.DataAnnotations;

namespace App.EndPoint.UI.Models
{
    public class LoginViewModel
    {
        [Required]
        //[EmailAddress]
        [Display(Name = "شناسه کاربری")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

        //[Display(Name = "من را به خاطر بسپار")]
        //public bool RememberMe { get; set; }
    }
}
