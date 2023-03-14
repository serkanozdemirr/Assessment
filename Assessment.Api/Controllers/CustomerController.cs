using Assessment.Core.Factory;
using Assessment.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assessment.Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CustomerController:ControllerBase
	{
		private readonly ILogger<CustomerController> _logger;
		private readonly CustomerService _customerService;
		public CustomerController(ILogger<CustomerController> logger, CustomerService customerService)
		{
			_logger = logger;
			_customerService = customerService;
		}

		[HttpGet(nameof(GetCustomers))]
		public async Task<List<Customer>> GetCustomers()
		{
			List<Customer> customers = await _customerService.GetCustomers();
            _logger.LogInformation("Customers Api çağrısı yapıldı ve " + customers.Count + " Adet çağrı döndü.");
            return customers;
		}
	}
}
