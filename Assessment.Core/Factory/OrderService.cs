using Assessment.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Core.Factory
{
	public class OrderService
	{
		public async Task<List<Order>> GetOrders()
		{
			var httpClient = new HttpClient();
			List<Order> orders = new();
			HttpResponseMessage response = await httpClient.GetAsync("https://northwind.vercel.app/api/orders");
			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				orders = JsonConvert.DeserializeObject<List<Order>>(content);
			}
			return orders;
		}
	}
}
