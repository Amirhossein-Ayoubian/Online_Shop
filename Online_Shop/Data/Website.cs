using Online_Shop.Models;
using System.Xml.Linq;

namespace Online_Shop.Data
{
    public class Website
    {
        public static List<Category> categories { get; set; }
        public static List<Product> products { get; set; }
        public static List<Item> items { get; set; }

        static Website()
        {
            categories = new List<Category>();
            products = new List<Product>();
            items = new List<Item>();

            AddNewCategory(1, "1c", "1c");
            AddNewCategory(2, "2c", "2c");
            AddNewCategory(3, "3c", "3c");
            AddNewCategory(4, "4c", "4c");

            AddNewItem(1, "1p", "1p", 1, 1, 100);
            AddNewItem(2, "2p", "2p", 2, 1, 100);
            AddNewItem(3, "3p", "3p", 3, 1, 100);
            AddNewItem(4, "4p", "4p", 4, 1, 100);
        }

        public static Category GetCategoryById(int id)
        {
            var category = categories.Find(c => c.id == id);
            return category ?? categories[0];
        }

        public static Product GetProductById(int id)
        {
            var product = products.Find(p => p.id == id);
            return product ?? products[0];
        }

        public static void AddNewCategory(int id, string name, string description)
        {
            categories.Add(new Category() { id = id, name = name, description = description });
        }

        public static void AddNewItem(int id, string name, string description, int categoryId, int count, int price)
        {
            products.Add(new Product() { id = id, name = name, description = description, category = GetCategoryById(categoryId) });
            items.Add(new Item() { product = GetProductById(id), count = count, price = price });
        }
    }
}
