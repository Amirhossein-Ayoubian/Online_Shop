using System.ComponentModel.DataAnnotations;

namespace Online_Shop.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string fullName { get; set; }
        public bool isAdmin { get; set; }
        public Cart cart { get; set; }
        public List<Cart> previousCarts { get; set; }

        public User()
        {
            cart = new Cart();
            previousCarts = new List<Cart>();
        }
    }
}
