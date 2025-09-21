namespace Online_Shop.Models
{
    public class CartViewModel
    {
        public List<CartItem> cartItems { get; set; }
        public decimal totalPrice { get; set; }

        public CartViewModel()
        {
            cartItems = new List<CartItem>();
        }
    }
}
