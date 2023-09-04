using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly JsonFileProductService _productService; // Inject the JsonFileProductService

        public IndexModel(ILogger<IndexModel> logger, JsonFileProductService productService)
        {
            _logger = logger;
            _productService = productService; // Inject JsonFileProductService
        }

        public IEnumerable<Product> Products { get; private set; } // Define a property to hold the products

        public void OnGet()
        {
            // Fetch the product data from the JsonFileProductService
            Products = _productService.GetProducts();
        }
    }
}