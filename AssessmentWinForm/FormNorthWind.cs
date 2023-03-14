using Assessment.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssessmentWinForm
{
    public partial class FormNorthWind : Form
    {
        public FormNorthWind()
        {
            InitializeComponent();
        }

        private async void bttnCatagories_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            List<Category> categories = new();
            HttpResponseMessage response = await client.GetAsync("https://localhost:7271/Category/GetCategories");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                categories = JsonConvert.DeserializeObject<List<Category>>(content);
            }
            dataGridView1.DataSource = categories;
        }

        private async void btnProducts_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            List<Product> products = new();
            HttpResponseMessage response = await client.GetAsync("https://localhost:7271/Product/GetProducts");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                products = JsonConvert.DeserializeObject<List<Product>>(content);
            }
            dataGridView1.DataSource = products;
        }

        private async void btnOrders_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            List<Order> orders = new();
            HttpResponseMessage response = await client.GetAsync("https://localhost:7271/Order/GetOrders");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                orders = JsonConvert.DeserializeObject<List<Order>>(content);
            }
            dataGridView1.DataSource = orders;
        }

        private async void btnCustomers_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            List<Customer> customers = new();
            HttpResponseMessage response = await client.GetAsync("https://localhost:7271/Customer/GetCustomers");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                customers = JsonConvert.DeserializeObject<List<Customer>>(content);
            }
            dataGridView1.DataSource = customers;
        }

        private async void btnSuppliers_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            List<Supplier> suppliers = new();
            HttpResponseMessage response = await client.GetAsync("https://localhost:7271/Supplier/GetSuppliers");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                suppliers = JsonConvert.DeserializeObject<List<Supplier>>(content);
            }
            dataGridView1.DataSource = suppliers;
        }

        private async void btnShippers_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            List<Shipper> shippers = new();
            HttpResponseMessage response = await client.GetAsync("https://localhost:7271/Shipper/GetShippers");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                shippers = JsonConvert.DeserializeObject<List<Shipper>>(content);
            }
            dataGridView1.DataSource = shippers;
        }

        private async void btnEmployess_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            List<Employee> employees = new();
            HttpResponseMessage response = await client.GetAsync("https://localhost:7271/Employee/GetEmployees");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                employees = JsonConvert.DeserializeObject<List<Employee>>(content);
            }
            dataGridView1.DataSource = employees;
        }
    }
}
