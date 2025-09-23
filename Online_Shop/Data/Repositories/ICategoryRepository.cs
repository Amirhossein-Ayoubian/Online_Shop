using Online_Shop.Models;

namespace Online_Shop.Data.Repositories
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories();
        public Category GetCategoryById(int id);

    }

    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories()
        {
            return Website.categories;
        }

        public Category GetCategoryById(int id)
        {
            return Website.categories.Find(p => p.id == id);
        }
    }
}
