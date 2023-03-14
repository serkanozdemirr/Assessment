using Assessment.Core.Factory;
using Assessment.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Assessment.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderService _orderService;
        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            List<Order> orders = new();
            HttpResponseMessage response = await client.GetAsync("https://localhost:7271/Order/GetOrders");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                orders = JsonConvert.DeserializeObject<List<Order>>(content);
            }
            //var shippers = await _shipperService.GetShippers();
            return View(orders);
        }
    }
}
