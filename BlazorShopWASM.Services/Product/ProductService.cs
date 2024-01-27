using BlazorShopWASM.Services.Product.Models;
using BlazorShopWASM.Services.Storage;

namespace BlazorShopWASM.Services.Product
{
    public class ProductService : IProductService
    {
        private readonly IStorageService _storageService;

        public ProductService(IStorageService storageService)
        {
            _storageService = storageService;
        }

        //Gets a product
        public ProductModel Get(string sku)
        {
            return _storageService.Products.FirstOrDefault(p => p.Sku == sku);
        }

        //Gets all products
        public IList<ProductModel> GetAll()
        {
            return _storageService.Products.ToList();
        }

        //Get a product by slug.
        public ProductModel GetBySlug(string slug)
        {
            return _storageService.Products.FirstOrDefault(p => p.Slug == slug);
        }
    }
}
