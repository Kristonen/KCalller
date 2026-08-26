using KCalller.Pages;

namespace KCalller.Services
{
    public class ProductRepository
    {
        public List<ProductInput> Products { get => _products; set => _products = value; }
        private List<ProductInput> _products = new();

        public void Add(ProductInput product)
        {
            _products.Add(product);
        }
    }
}
