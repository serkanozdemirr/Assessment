using Assessment.Core.Factory;
using Assessment.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assessment.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly EmployeeService _employeeService;
        public EmployeeController(ILogger<EmployeeController> logger, EmployeeService employeeService)
        {
            _logger = logger;
            _employeeService = employeeService;
        }

        [HttpGet(nameof(GetEmployees))]
        public async Task<List<Employee>> GetEmployees()
        {
            List<Employee> employees = await _employeeService.GetEmployees();
            _logger.LogInformation("Employees Api çağrısı yapıldı ve " + employees.Count + " Adet çağrı döndü.");
            return employees;
        }
    }
}
