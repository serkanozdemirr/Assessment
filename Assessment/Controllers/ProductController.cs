using Assessment.Core.Factory;
using Assessment.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Assessment.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;
        public ProductController(ProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            List<Product> products = new();
            HttpResponseMessage response = await client.GetAsync("https://localhost:7271/Product/GetProducts");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                products = JsonConvert.DeserializeObject<List<Product>>(content);
            }
            //var shippers = await _shipperService.GetShippers();
            return View(products);
        }
    }
}
