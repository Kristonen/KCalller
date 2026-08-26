using KCalller.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KCalller.Pages
{
    public class CreateProductModel : PageModel
    {
        private readonly ProductRepository _repository;

        [BindProperty]
        public ProductInput ProductInput { get; set; } = new();

        public CreateProductModel(ProductRepository productRepository)
        {
            _repository = productRepository;
            Console.WriteLine(productRepository.Products.Count);
        }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _repository.Add(ProductInput);
            return RedirectToPage("/Product");
        }
    }

    public class ProductInput
    {
        public string Name { get; set; }
        public decimal CaloriesPer {  get; set; }
        public string ServingUnit { get; set; }
        public decimal ServingWeight { get; set; }
    }
}
