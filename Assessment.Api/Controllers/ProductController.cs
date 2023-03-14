using Assessment.Core.Factory;
using Assessment.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assessment.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController:ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly ProductService _productService;
        public ProductController(ILogger<ProductController> logger, ProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet(nameof(GetProducts))]
        public async Task<List<Product>> GetProducts()
        {
            List<Product> products = await _productService.GetProducts();
            _logger.LogInformation("Products Api çağrısı yapıldı ve " + products.Count + " Adet çağrı döndü.");
            return products;
        }
    }
}
