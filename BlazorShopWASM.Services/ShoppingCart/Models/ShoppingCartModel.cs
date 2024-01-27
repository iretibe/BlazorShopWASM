namespace BlazorShopWASM.Services.ShoppingCart.Models
{
    public class ShoppingCartModel
    {
        //A list of all the items stored in the shopping cart.
        public IList<ShoppingCartItemModel> Items { get; }

        //Constructs a new shopping cart.
        public ShoppingCartModel()
        {
            Items = new List<ShoppingCartItemModel>();
        }
    }
}
