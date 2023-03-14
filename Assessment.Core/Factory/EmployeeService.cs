using Assessment.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Core.Factory
{
    public class EmployeeService
    {
        public async Task<List<Employee>> GetEmployees()
        {
            var httpClient = new HttpClient();
            List<Employee> employees = new();
            HttpResponseMessage response = await httpClient.GetAsync("https://northwind.vercel.app/api/employess");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                employees = JsonConvert.DeserializeObject<List<Employee>>(content);
            }
            return employees;
        }
    }
}
