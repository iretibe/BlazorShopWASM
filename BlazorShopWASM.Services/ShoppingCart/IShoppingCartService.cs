using BlazorShopWASM.Services.Product.Models;
using BlazorShopWASM.Services.ShoppingCart.Models;

namespace BlazorShopWASM.Services.ShoppingCart
{
    //Used for shopping cart methods.
    public interface IShoppingCartService
    {
        //Get the shopping cart
        ShoppingCartModel Get();

        //Adds a product to the current shopping cart.
        void AddProduct(ProductModel product, int quantity);

        //Deletes a product from the shopping cart
        void DeleteProduct(ShoppingCartItemModel item);

        //Gets the number of items added to the current shopping cart.
        int Count();

        //Has a product been added to the shopping cart?
        bool HasProduct(string sku);
    }
}
