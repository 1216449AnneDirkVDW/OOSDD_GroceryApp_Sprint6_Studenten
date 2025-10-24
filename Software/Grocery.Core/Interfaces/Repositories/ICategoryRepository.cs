using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Repositories
{
    public interface ICategoryRepository
    {
        public Category? Get(int id);
        public List<Category> GetAll();
    }
}
