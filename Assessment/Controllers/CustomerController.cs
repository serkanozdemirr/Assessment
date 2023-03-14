using Assessment.Core.Factory;
using Assessment.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Assessment.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerService _customerService;
        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            List<Customer> customers = new();
            HttpResponseMessage response = await client.GetAsync("https://localhost:7271/Customer/GetCustomers");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                customers = JsonConvert.DeserializeObject<List<Customer>>(content);
            }
            //var shippers = await _shipperService.GetShippers();
            return View(customers);
        }
    }
}
