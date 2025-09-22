using Microsoft.AspNetCore.Mvc;
using Online_Shop.Data;
using Online_Shop.Models;

namespace Online_Shop.Controllers
{
    public class CartController:Controller
    {
        private readonly ILogger<HomeController> _logger;

        public CartController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddToCart(int productId)
        {
            var item = Website.items.Find(p => p.product.id == productId);
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

            return RedirectToAction("CartDetail");
        }

        [HttpPost]
        public IActionResult RemoveFromCart(int productId)
        {
            var item = Website.items.Find(p => p.product.id == productId);
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

            return View(Website.cart);
        }

        public IActionResult Checkout()
        {
            return RedirectToAction("Index");
        }
    }
}
