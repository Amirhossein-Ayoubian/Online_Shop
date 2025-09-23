using Microsoft.AspNetCore.Mvc;
using Online_Shop.Data;
using Online_Shop.Data.Repositories;
using Online_Shop.Models;
using System.Diagnostics;

namespace Online_Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IItemRepository _itemRepository;

        public HomeController(ILogger<HomeController> logger, IItemRepository itemRepository)
        {
            _logger = logger;
            _itemRepository = itemRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["ShowCategories"] = false;
            return View();
        }

        public IActionResult ContactUs()
        {
            ViewData["ShowCategories"] = false;
            return View();
        }

        public IActionResult Products()
        {
            return View(_itemRepository.GetAllItems());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            ViewData["ShowCategories"] = false;
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
