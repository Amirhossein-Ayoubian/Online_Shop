using Microsoft.AspNetCore.Mvc;
using Online_Shop.Data;
using Online_Shop.Models;

namespace Online_Shop.Controllers
{
    public class DetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ItemDetail(int id)
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
    }
}
