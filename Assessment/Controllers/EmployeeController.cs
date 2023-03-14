using Assessment.Core.Factory;
using Assessment.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Assessment.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeService _employeeService;
        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            List<Employee> employees = new();
            HttpResponseMessage response = await client.GetAsync("https://localhost:7271/Employee/GetEmployees");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                employees = JsonConvert.DeserializeObject<List<Employee>>(content);
            }
            //var shippers = await _shipperService.GetShippers();
            return View(employees);
        }
    }
}
