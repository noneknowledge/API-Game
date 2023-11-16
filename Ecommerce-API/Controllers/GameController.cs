using Ecommerce_API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GameController : ControllerBase
	{
		private readonly IGameRepo _repo;

		public GameController(IGameRepo repo)
		{
			_repo = repo;
		}
		[HttpGet]
		public async Task<IActionResult> GetAllGame()
		{
			try
			{
				return Ok(await _repo.GetAllGame());
			}
			catch
			{
				return BadRequest();
			}
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetGame(string id)
		{
			try
			{
				var data = await _repo.GetGame(id);
				return Ok(data);
			}
			catch
			{
				return BadRequest();
			}
			
		}


	}
}
