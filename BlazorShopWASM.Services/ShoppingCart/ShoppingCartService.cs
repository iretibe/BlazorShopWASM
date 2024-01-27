using BlazorShopWASM.Services.Product.Models;
using BlazorShopWASM.Services.ShoppingCart.Models;
using BlazorShopWASM.Services.Storage;

namespace BlazorShopWASM.Services.ShoppingCart
{
    public class ShoppingCartService : IShoppingCartService
    {
        //A private reference to the storage service from the DI container.
        private readonly IStorageService _storageService;

        //Constructs a shopping cart service.
        public ShoppingCartService(IStorageService storageService)
        {
            _storageService = storageService;
        }

        //Adds a product to the shopping cart.
        public void AddProduct(ProductModel product, int quantity)
        {
            //Get all items from shopping cart.
            var items = Get().Items;

            if (HasProduct(product.Sku))
            {
                //Product exists, so find it in the shopping cart.
                var item = items.First(i => i.Product.Sku == product.Sku);

                //Update quantity of the item.
                item.UpdateQuantity(product, quantity);
            }
            else
            {
                //Add the item to the shopping cart.
                items.Add(new ShoppingCartItemModel(product, quantity));
            }
        }

        //Gets the number of items added to the current shopping cart.
        public int Count()
        {
            return Get().Items.Count();
        }

        //Deletes a product from the shopping cart
        public void DeleteProduct(ShoppingCartItemModel item)
        {
            //Get all items from the cart.
            var items = Get().Items;

            if (HasProduct(item.Product.Sku))
            {
                //Delete item from shopping cart
                items.Remove(items.First(i => i.Product.Sku == item.Product.Sku));
            }
        }

        //Gets the shopping cart.
        public ShoppingCartModel Get()
        {
            return _storageService.ShoppingCart;
        }

        //Has a product been added to the shopping cart?
        public bool HasProduct(string sku)
        {
            var shoppingCart = Get();

            return shoppingCart.Items.Any(i => i.Product.Sku == sku);
        }
    }
}
