using Assessment.Core.Factory;
using Assessment.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Assessment.Controllers
{
	public class ShipperController : Controller
	{
        private readonly ShipperService _shipperService;
		public ShipperController(ShipperService shipperService)
        {
            _shipperService = shipperService;
        }
		public async Task<IActionResult> Index()
		{
			var client = new HttpClient();
			List<Shipper> shippers = new();
			HttpResponseMessage response = await client.GetAsync("https://localhost:7271/Shipper/GetShippers");
			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				shippers = JsonConvert.DeserializeObject<List<Shipper>>(content);
			}
			//var shippers = await _shipperService.GetShippers();
			return View(shippers);
		}
	}
}
