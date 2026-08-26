using KCalller.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KCalller.Pages
{
    public class ProductModel : PageModel
    {
        private readonly ProductRepository _repository;
        public ProductModel(ProductRepository productRepository)
        {
            _repository = productRepository;
        }
        public List<ProductInput> Products { get; set; } = new();

        public void OnGet()
        {
            Products = _repository.Products;
        }
    }
}
