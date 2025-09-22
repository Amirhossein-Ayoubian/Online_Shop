using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Online_Shop.Data;
using Online_Shop.Models;

namespace Online_Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View(Website.items);
        }

        public IActionResult Detail(int id)
        {
            var item = Website.items.Find(p => p.product.id == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        public IActionResult CategoryDetail(int id)
        {
            var category = Website.categories.Find(p => p.id == id);
            if (category == null)
            {
                return NotFound();
            }

            List<Item> items = new List<Item>();
            foreach (var item in Website.items)
            {
                if (item.product.category.id == id)
                {
                    items.Add(item);
                }
            }

            CategoryItemViewModel viewModel = new CategoryItemViewModel()
            {
                category = category,
                items = items
            };

            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
