using Ecommerce_API.Repositories;
using Ecommerce_API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OrderController : ControllerBase
	{
		private readonly IOrderRepo _repo;

		public OrderController(IOrderRepo repo)
		{
			_repo = repo;
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetOrder(string id)
		{
			try
			{
				var data = await _repo.GetOrder(id);
				return Ok(data);
			}
			catch
			{
				return BadRequest();
			}
		}

		[HttpPost]
		public async Task<IActionResult> AddOrder(OrderVM vm)
		{
			try
			{
				var data = await _repo.AddOrder(vm);
				return Ok(data);
			}
			catch
			{
				return BadRequest();
			}
		}

	}
}
