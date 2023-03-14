using Assessment.Core.Factory;
using Assessment.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Assessment.Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class SupplierController: ControllerBase
	{
		private readonly ILogger<SupplierController> _logger;
		private readonly SupplierService _supplierService;
		public SupplierController(ILogger<SupplierController> logger, SupplierService supplierService)
		{
			_logger = logger;
			_supplierService = supplierService;
		}

		[HttpGet(nameof(GetSuppliers))]
		public async Task<List<Supplier>> GetSuppliers()
		{
			var suppliers = await _supplierService.GetSuppliers();
            _logger.LogInformation("Suppliers Api çağrısı yapıldı ve " + suppliers.Count + " Adet çağrı döndü.");
            return suppliers;
		}
	}
}
