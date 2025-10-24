namespace Grocery.Core.Models
{
    public class ProductCategory : Model
    {
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public ProductCategory(int id, int categoryId, int productId) : base(id, "")
        {
            CategoryId = categoryId;
            ProductId = productId;
        }

        public Product? Product { get; set; }
        public Category? Category { get; set; }
    }
}
