using Ecommerce_API.Repositories;
using Ecommerce_API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AdminController : ControllerBase
	{
		private readonly IAdminRepo _repo;

		public AdminController(IAdminRepo repo)
		{
			_repo = repo;
		}
		[HttpPost("Login")]
		public async Task<IActionResult> Login(LoginVM vm)
		{
			try
			{
				var user = await _repo.LoginAdmin(vm);
				return Ok(user);
			}
			catch
			{
				return BadRequest();
			}

		}

		[HttpPost]
		public async Task<IActionResult> AddUser(AdminVM vm)
		{
			try
			{
				var data = await _repo.AddAdmin(vm);
				return Ok(data);
			}
			catch
			{
				return BadRequest();
			}
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateUser(string id, AdminVM vm)
		{
			try
			{
				var data = await _repo.UpdateAdmin(id, vm);
				return Ok(data);
			}
			catch
			{
				return BadRequest();
			}
		}
		[HttpPut("Disable/{id}")]
		public async Task<IActionResult> DisableUser(string id)
		{
			try
			{
				await _repo.DisableAdmin(id);
				return Ok();
			}
			catch
			{
				return BadRequest();
			}
		}

	}
}
