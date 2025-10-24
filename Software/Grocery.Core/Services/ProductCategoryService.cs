
using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.Core.Services
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IProductCategoryRepository _productCategoriesRepository;
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductCategoryService(IProductCategoryRepository productCategoriesRepository, IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productCategoriesRepository = productCategoriesRepository;
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            FillService();
        }

        private void FillService()
        {
            foreach (ProductCategory pc in _productCategoriesRepository.GetAll())
            {
                pc.Product = _productRepository.Get(pc.ProductId) ?? new(0, "", 0);
                pc.Category = _categoryRepository.Get(pc.CategoryId) ?? new(0, "");
            }
        }
        public ProductCategory Add(ProductCategory item)
        {
            _productCategoriesRepository.Add(item);
            return item;
        }

        public List<ProductCategory> GetAll()
        {
            return _productCategoriesRepository.GetAll();
        }

        public List<ProductCategory> GetAllOnCategoryId(int id)
        {
            return _productCategoriesRepository.GetAll().Where(p => p.CategoryId == id).ToList();
        }
    }
}
