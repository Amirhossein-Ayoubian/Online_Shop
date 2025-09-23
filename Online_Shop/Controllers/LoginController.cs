using Microsoft.AspNetCore.Mvc;
using Online_Shop.Models;

namespace Online_Shop.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            ViewData["ShowCategories"] = false;
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            ModelState.AddModelError("", "نام کاربری یا رمز عبور اشتباه است");
            return View(model);
        }
    }
}
