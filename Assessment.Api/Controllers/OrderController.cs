using Assessment.Core.Factory;
using Assessment.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assessment.Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class OrderController:ControllerBase
	{
		private readonly ILogger<OrderController> _logger;
		private readonly OrderService _orderService;
		public OrderController(ILogger<OrderController> logger, OrderService orderService)
		{
			_logger = logger;
			_orderService = orderService;
		}

		[HttpGet(nameof(GetOrders))]
		public async Task<List<Order>> GetOrders()
		{
			List<Order> orders = await _orderService.GetOrders();
            _logger.LogInformation("Orders Api çağrısı yapıldı ve " + orders.Count + " Adet çağrı döndü.");
            return orders;
		}
	}
}
