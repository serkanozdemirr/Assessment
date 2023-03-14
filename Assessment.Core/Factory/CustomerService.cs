using Assessment.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Core.Factory
{
	public class CustomerService
	{
		public async Task<List<Customer>> GetCustomers()
		{
			var httpClient = new HttpClient();
			List<Customer> customers = new();
			HttpResponseMessage response = await httpClient.GetAsync("https://northwind.vercel.app/api/customers");
			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				customers = JsonConvert.DeserializeObject<List<Customer>>(content);
			}
			return customers;
		}
	}
}
