using BlazorShopWASM.Services.Product.Models;
using BlazorShopWASM.Services.ShoppingCart.Models;

namespace BlazorShopWASM.Services.Storage
{
    public interface IStorageService
    {
        //Stores a list of products.
        IList<ProductModel> Products { get; }

        //Stores the shopping cart.
        ShoppingCartModel ShoppingCart { get; }
    }
}
