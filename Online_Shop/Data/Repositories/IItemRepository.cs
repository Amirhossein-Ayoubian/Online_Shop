using Online_Shop.Models;

namespace Online_Shop.Data.Repositories
{
    public interface IItemRepository
    {
        public IEnumerable<Item> GetAllItems();
        public Item GetItemById(int id);
        public IEnumerable<Item> GetItemsByCategory(int categoryId);
        public void RemoveItem(Item item);
    }

    public class ItemRepository : IItemRepository
    {
        public IEnumerable<Item> GetAllItems()
        {
            return Website.items;
        }

        public Item GetItemById(int id)
        {
            return Website.items.Find(p => p.product.id == id);
        }

        public IEnumerable<Item> GetItemsByCategory(int categoryId)
        {
            List<Item> items = new List<Item>();
            foreach (var item in GetAllItems())
            {
                if (item.product.category.id == categoryId)
                {
                    items.Add(item);
                }
            }

            return items;
        }

        public void RemoveItem(Item item)
        {
            Website.items.Remove(item);
        }
    }
}
