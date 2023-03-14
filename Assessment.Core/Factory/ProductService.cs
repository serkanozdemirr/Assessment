using Assessment.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Core.Factory
{
    public class ProductService
    {
        public async Task<List<Product>> GetProducts()
        {
            var httpClient = new HttpClient();
            List<Product> products = new();
            HttpResponseMessage response = await httpClient.GetAsync("https://northwind.vercel.app/api/products");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                products = JsonConvert.DeserializeObject<List<Product>>(content);
            }
            return products;
        }
    }
}
