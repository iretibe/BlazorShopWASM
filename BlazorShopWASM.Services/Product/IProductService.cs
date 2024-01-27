using BlazorShopWASM.Services.Product.Models;

namespace BlazorShopWASM.Services.Product
{
    public interface IProductService
    {
        ProductModel Get(string sku);
        ProductModel GetBySlug(string slug);
        IList<ProductModel> GetAll();
    }
}
