using Microsoft.AspNetCore.Mvc;
using Online_Shop.Data;
using Online_Shop.Data.Repositories;
using Online_Shop.Models;

namespace Online_Shop.Controllers
{
    public class CartController:Controller
    {
        private readonly ILogger<CartController> _logger;
        private readonly IItemRepository _itemRepository;

        public CartController(ILogger<CartController> logger, IItemRepository itemRepository)
        {
            _logger = logger;
            _itemRepository = itemRepository;
        }

        public IActionResult Index()
        {
            ViewData["ShowCategories"] = false;
            return View();
        }

        [HttpPost]
        public IActionResult AddToCart(int productId)
        {
            var item = _itemRepository.GetItemById(productId);
            if (item == null)
            {
                return NotFound();
            }

            CartItem cartItem = new CartItem()
            {
                item = item,
                count = 1
            };

            Website.cart.AddItem(cartItem);

            if (item.count < Website.cart.cartItems.Find(c => c.item.product.id == cartItem.item.product.id).count)
            {
                Website.cart.RemoveItem(cartItem);
            }

            return RedirectToAction("CartDetail");
        }

        [HttpPost]
        public IActionResult RemoveFromCart(int productId)
        {
            var item = _itemRepository.GetItemById(productId);
            if (item == null)
            {
                return NotFound();
            }

            CartItem cartItem = new CartItem()
            {
                item = item,
                count = 1
            };

            Website.cart.RemoveItem(cartItem);
            return RedirectToAction("CartDetail");
        }

        public IActionResult CartDetail()
        {
            if (Website.cart.cartItems.Count == 0)
            {
                return RedirectToAction("Index");
            }

            CartViewModel viewModel = new CartViewModel()
            {
                cartItems = Website.cart.cartItems,
                totalPrice = Website.cart.cartItems.Sum(c => c.getTotalPrice())
            };

            ViewData["ShowCategories"] = false;
            return View(viewModel);
        }

        public IActionResult Checkout()
        {
            decimal totalPrice = 0;
            foreach (var item in Website.cart.cartItems)
            {
                var myItem = item.item;
                if (item.count <= myItem.count)
                {
                    item.count = myItem.count;

                    totalPrice += item.getTotalPrice();

                    var i = item.item;
                    i.count -= item.count;
                    if (i.count < 1)
                    {
                        _itemRepository.RemoveItem(i);
                    }
                }
            }

            Website.cart.cartItems = new List<CartItem>();

            return RedirectToAction("CartDetail");
        }
    }
}
