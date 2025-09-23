namespace Online_Shop.Models
{
    using System.ComponentModel.DataAnnotations;

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "نام کاربری الزامی است")]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "نام کاربری")]
        public string username { get; set; }

        [Required(ErrorMessage = "رمز عبور الزامی است")]
        [StringLength(100, MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "رمز عبور")]
        public string password { get; set; }

        [Required(ErrorMessage = "تکرار رمز عبور الزامی است")]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "رمز عبور و تکرار آن مطابقت ندارند")]
        [Display(Name = "تکرار رمز عبور")]
        public string confirmPassword { get; set; }

        [Required(ErrorMessage = "ایمیل الزامی است")]
        [EmailAddress(ErrorMessage = "ایمیل نامعتبر است")]
        [Display(Name = "ایمیل")]
        public string email { get; set; }

        [Required(ErrorMessage = "نام کامل الزامی است")]
        [StringLength(100)]
        [Display(Name = "نام کامل")]
        public string fullName { get; set; }
    }

}
