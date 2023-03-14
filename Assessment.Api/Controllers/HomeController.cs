using Assessment.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Assessment.Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class HomeController: ControllerBase
	{
		private readonly ILogger<HomeController> _logger;
		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}


	}
}
