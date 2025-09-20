namespace Online_Shop.Models
{
    public class Cart
    {
        public int id { get; set; }
        public List<CartItem> cartItems { get; set; }

        public Cart()
        {
            cartItems = new List<CartItem>();
        }

        public void AddItem(CartItem item)
        {
            if (cartItems.Exists(i => i.item.product.id == item.item.product.id))
            {
                cartItems.Find(i => i.item.product.id == item.item.product.id).count++;
            }
            else
            {
                cartItems.Add(item);
            }
        }

        public void RemoveItem(CartItem item) 
        {
            if (cartItems.Exists(i => i.item.product.id == item.item.product.id))
            {
                CartItem CartItem = cartItems.Find(i => i.item.product.id == item.item.product.id);
                CartItem.count--;

                if (CartItem.count == 0)
                {
                    cartItems.Remove(CartItem);
                }
            }
        }
    }
}
