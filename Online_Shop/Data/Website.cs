using Online_Shop.Models;
using System.Xml.Linq;

namespace Online_Shop.Data
{
    public class Website
    {
        public static List<Category> categories { get; set; }
        public static List<Product> products { get; set; }
        public static List<Item> items { get; set; }

        public static Cart cart { get; set; }

        static Website()
        {
            categories = new List<Category>();
            products = new List<Product>();
            items = new List<Item>();

            AddNewCategory(1, "دسته بندی شماره 1", "این یک توضیح ساده در مورد این دسته بندی میباشد");
            AddNewCategory(2, "دسته بندی شماره 2", "این یک توضیح ساده در مورد این دسته بندی میباشد");
            AddNewCategory(3, "دسته بندی شماره 3", "این یک توضیح ساده در مورد این دسته بندی میباشد");
            AddNewCategory(4, "دسته بندی شماره 4", "این یک توضیح ساده در مورد این دسته بندی میباشد");

            AddNewItem(1, "محصول شماره 1", "این یک توضیح ساده در مورد این محصول میباشد", 1, 1, 100);
            AddNewItem(2, "محصول شماره 2", "این یک توضیح ساده در مورد این محصول میباشد", 2, 1, 100);
            AddNewItem(3, "محصول شماره 3", "این یک توضیح ساده در مورد این محصول میباشد", 3, 1, 100);
            AddNewItem(4, "محصول شماره 4", "این یک توضیح ساده در مورد این محصول میباشد", 4, 1, 100);

            cart = new Cart()
            {
                id = 1
            };
        }

        private static Category GetCategoryById(int id)
        {
            var category = categories.Find(c => c.id == id);
            return category ?? categories[0];
        }

        private static Product GetProductById(int id)
        {
            var product = products.Find(p => p.id == id);
            return product ?? products[0];
        }

        private static Item GetItemById(int id)
        {
            var item = items.Find(p => p.product.id == id);
            return item ?? items[0];
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
