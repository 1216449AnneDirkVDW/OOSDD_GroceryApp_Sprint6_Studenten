using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Repositories
{
    public interface IGroceryListRepository
    {
        public List<GroceryList> GetAll();
        public GroceryList Add(GroceryList item);

        public GroceryList? Delete(GroceryList item);

        public GroceryList? Get(int id);

        public GroceryList? Update(GroceryList item);
    }
}
