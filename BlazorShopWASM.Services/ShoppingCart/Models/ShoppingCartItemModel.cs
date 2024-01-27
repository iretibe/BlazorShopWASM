using BlazorShopWASM.Services.Product.Models;

namespace BlazorShopWASM.Services.ShoppingCart.Models
{
    public class ShoppingCartItemModel
    {
        //Product type.
        public ProductModel Product { get; }

        //Price of the product.
        public decimal Price { get; protected set; }

        //Quantity of the product.
        public int Quantity { get; protected set; }

        //Get the total price of the product.
        public decimal TotalPrice
        {
            get
            {
                return Price * Quantity;
            }
        }

        //Constructs a new shopping cart item.
        public ShoppingCartItemModel(ProductModel product, int quantity)
        {
            Product = product;
            Price = product.Price;
            Quantity = quantity;
        }

        //Updates the quantity and the price.
        public void UpdateQuantity(ProductModel product, int quantity)
        {
            Price = product.Price;
            Quantity += quantity;
        }
    }
}
