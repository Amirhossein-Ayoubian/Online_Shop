using System.ComponentModel.DataAnnotations;

namespace Online_Shop.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "نام کاربری الزامی است")]
        [Display(Name = "نام کاربری")]
        public string username { get; set; }

        [Required(ErrorMessage = "رمز عبور الزامی است")]
        [DataType(DataType.Password)]
        [Display(Name = "رمز عبور")]
        public string password { get; set; }

        [Display(Name = "مرا به خاطر بسپار")]
        public bool rememberMe { get; set; }
    }
}
