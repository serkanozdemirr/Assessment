using Assessment.Core.Factory;
using Assessment.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Assessment.Controllers
{
    public class SupplierController : Controller
    {
        private readonly SupplierService _supplierService;
        public SupplierController(SupplierService supplierService)
        {
            _supplierService = supplierService;
        }
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            List<Supplier> suppliers = new();
            HttpResponseMessage response = await client.GetAsync("https://localhost:7271/Supplier/GetSuppliers");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                suppliers = JsonConvert.DeserializeObject<List<Supplier>>(content);
            }
            //var shippers = await _shipperService.GetShippers();
            return View(suppliers);
        }
    }
}
