namespace Online_Shop.Models
{
    public class CartItem
    {
        public Item item { get; set; }
        public int count { get; set; }

        public int getTotalPrice()
        {
            return count * item.price;
        } 
    }
}
