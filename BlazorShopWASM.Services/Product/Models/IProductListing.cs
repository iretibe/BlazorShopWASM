namespace BlazorShopWASM.Services.Product.Models
{
    public interface IProductListing
    {
        //An instance of the product
        ProductModel? Product { get; set; }

        // The quantity wishing to be added to the cart
        int? Quantity { get; set; }
    }
}
