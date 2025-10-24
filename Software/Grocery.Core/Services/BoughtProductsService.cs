using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.Core.Services
{
    public class BoughtProductsService : IBoughtProductsService
    {
        private readonly IGroceryListItemsRepository _groceryListItemsRepository;
        private readonly IClientRepository _clientRepository;
        private readonly IProductRepository _productRepository;
        private readonly IGroceryListRepository _groceryListRepository;
        public BoughtProductsService(IGroceryListItemsRepository groceryListItemsRepository, IGroceryListRepository groceryListRepository, IClientRepository clientRepository, IProductRepository productRepository) 
        {
            _groceryListItemsRepository=groceryListItemsRepository;
            _groceryListRepository=groceryListRepository;
            _clientRepository=clientRepository;
            _productRepository=productRepository;
        }
        public List<BoughtProducts> Get(int? productId)
        {
            List<BoughtProducts> boughtProducts = [];
            var MyGroceryListItems = _groceryListItemsRepository.GetAll();
            if (productId.HasValue && MyGroceryListItems != null && MyGroceryListItems.Count > 0)
            {
                Product product = _productRepository.Get(productId.GetValueOrDefault());
                foreach (var item in MyGroceryListItems)
                {
                    if (item.ProductId == productId)
                    {
                        GroceryList groceryList = _groceryListRepository.Get(item.GroceryListId);
                        Client client = _clientRepository.Get(groceryList.ClientId);
                        boughtProducts.Add(new(client, groceryList, product));
                    }
                }
            }
            return boughtProducts;
        }
    }
}
