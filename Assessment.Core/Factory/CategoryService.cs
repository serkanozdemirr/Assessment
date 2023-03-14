using Assessment.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Core.Factory
{
    public class CategoryService
    {
        public async Task<List<Category>> GetCategory()
        {
            var httpClient = new HttpClient();
            List<Category> categories = new();
            HttpResponseMessage response = await httpClient.GetAsync("https://northwind.vercel.app/api/categories");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                categories = JsonConvert.DeserializeObject<List<Category>>(content);
            }
            return categories;
        }
    }
}
