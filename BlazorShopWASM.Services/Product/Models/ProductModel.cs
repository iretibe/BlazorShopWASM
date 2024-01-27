namespace BlazorShopWASM.Services.Product.Models
{
    public class ProductModel
    {
        public string Sku { get; }
        public string Name { get; }
        public decimal Price { get; }
        public string Image { get; }
        public string Slug
        {
            get
            {
                return Sku.ToLower();
            }
        }
        public string FullUrl
        {
            get
            {
                return string.Format("/product/{0}", Slug);
            }
        }

        public ProductModel(string sku, string name, decimal price, string image)
        {
            Sku = sku;
            Name = name;
            Price = price;
            Image = image;
        }
    }
}
