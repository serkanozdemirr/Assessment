using Assessment.Core.Factory;
using Assessment.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assessment.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController:ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly CategoryService _categoryService;
        public CategoryController(ILogger<CategoryController> logger, CategoryService categoryService)
        {
            _logger = logger;
            _categoryService = categoryService;
        }

        [HttpGet(nameof(GetCategories))]
        public async Task<List<Category>> GetCategories()
        {
            List<Category> categories = await _categoryService.GetCategory();
            _logger.LogInformation("Categories Api çağrısı yapıldı ve " + categories.Count + " Adet çağrı döndü.");
            return categories;
        }
    }
}
