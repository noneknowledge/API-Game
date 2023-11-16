using AutoMapper;
using Ecommerce_API.Models;
using Ecommerce_API.Repositories;
using Ecommerce_API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
		private readonly Game_DBContext _ctx;
		private readonly IClientRepo _repo;

        public ClientController( IClientRepo repo, Game_DBContext context)
        {
            _ctx = context;
            _repo = repo;
        }
        [HttpGet]
        public IActionResult GetallClient()
        {
            var data = _ctx.Clients.ToList();
            return Ok(data);
        }
        

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginVM vm)
        {
            try
            {
                var user = await _repo.LoginUser(vm);
                return Ok(user);
            }
            catch
            {
                return BadRequest();
            }

        }

        [HttpPost]
        public async Task<IActionResult> AddUser(ClientVM vm)
        {
            try
            {
                var data = await _repo.AddUser(vm);
                return Ok(data);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(string id, ClientVM vm)
        {
            try
            {
                var data = await _repo.UpdateUser(id, vm);
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
                await _repo.DisableUser(id);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}
