using Assessment.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Core.Factory
{
	public class SupplierService
	{
		public async Task<List<Supplier>> GetSuppliers()
		{
			var httpClient = new HttpClient();
			List<Supplier> suppliers = new();
			HttpResponseMessage response = await httpClient.GetAsync("https://northwind.vercel.app/api/suppliers");
			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				suppliers = JsonConvert.DeserializeObject<List<Supplier>>(content);
			}
			return suppliers;
		}
	}
}
