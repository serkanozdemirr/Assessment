using Assessment.Core.Factory;
using Assessment.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Assessment.Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ShipperController: ControllerBase
	{

		private readonly ILogger<ShipperController> _logger;
		private readonly ShipperService _shipperService;
		public ShipperController(ILogger<ShipperController> logger, ShipperService shipperService)
		{
			_logger = logger;
			_shipperService = shipperService;
		}

		[HttpGet(nameof(GetShippers))]
		public async Task<List<Shipper>> GetShippers()
		{
			List<Shipper> shippers = await _shipperService.GetShippers();
            _logger.LogInformation("Shippers Api çağrısı yapıldı ve " + shippers.Count + " Adet çağrı döndü.");
            return shippers;
		}
	}
}
