using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Repositories
{
    public interface IProductCategoryRepository
    {
        public ProductCategory Add(ProductCategory item);

        public List<ProductCategory> GetAll();
    }
}
