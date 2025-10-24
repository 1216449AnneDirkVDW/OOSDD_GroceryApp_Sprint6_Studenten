using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly List<ProductCategory> productCategories;

        public ProductCategoryRepository()
        {
            productCategories = [
                new ProductCategory(1, 3, 1),
                new ProductCategory(2, 3, 2),
                new ProductCategory(3, 2, 3),
                new ProductCategory(4, 5, 4),
                ];
        }

        public Models.ProductCategory Add(Models.ProductCategory item)
        {
            productCategories.Add(item);
            return item;
        }

        public List<Models.ProductCategory> GetAll()
        {
            return productCategories;
        }
    }
}
