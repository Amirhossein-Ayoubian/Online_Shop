using Microsoft.AspNetCore.Mvc;
using Online_Shop.Data;
using Online_Shop.Data.Repositories;
using Online_Shop.Models;

namespace Online_Shop.Controllers
{
    public class DetailController : Controller
    {
        private readonly ILogger<DetailController> _logger;
        private readonly IItemRepository _itemRepository;
        private readonly ICategoryRepository _categoryRepository;

        public DetailController(ILogger<DetailController> logger, IItemRepository itemRepository, 
            ICategoryRepository categoryRepository)
        {
            _logger = logger;
            _itemRepository = itemRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ItemDetail(int id)
        {
            var item = _itemRepository.GetItemById(id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        public IActionResult CategoryDetail(int id)
        {
            var category = _categoryRepository.GetCategoryById(id);
            if (category == null)
            {
                return NotFound();
            }

            List<Item> items = (List<Item>)_itemRepository.GetItemsByCategory(id);

            CategoryItemViewModel viewModel = new CategoryItemViewModel()
            {
                category = category,
                items = items
            };

            return View(viewModel);
        }
    }
}
