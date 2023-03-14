using Assessment.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Core.Factory
{
	public class ShipperService
	{
		public async Task<List<Shipper>> GetShippers()
		{
			var httpClient = new HttpClient();
			List<Shipper> shippers = new();
			HttpResponseMessage response = await httpClient.GetAsync("https://northwind.vercel.app/api/shippers");
			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				shippers = JsonConvert.DeserializeObject<List<Shipper>>(content);
			}
			return shippers;
		}
	}
}
