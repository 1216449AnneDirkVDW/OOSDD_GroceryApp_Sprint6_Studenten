using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly List<Category> categories;
        public CategoryRepository()
        {
            categories = [
                new Category(1, "Groente"),
                new Category(2, "Bakkerij"),
                new Category(3, "Zuivel"),
                new Category(4, "Conserven"),
                new Category(5, "Ontbijt")];
        }

        public Category? Get(int id)
        {
            return categories.FirstOrDefault(c => c.Id == id);
        }

        public List<Category> GetAll()
        {
            return categories;
        }
    }
}
