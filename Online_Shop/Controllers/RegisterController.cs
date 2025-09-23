using Microsoft.AspNetCore.Mvc;
using Online_Shop.Models;

namespace Online_Shop.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            ViewData["ShowCategories"] = false;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            TempData["SuccessMessage"] = "ثبت‌نام با موفقیت انجام شد (نسخه‌ی دمو)";
            return RedirectToAction("Index", "Home");
        }
    }
}
