using Ecommerce_API.Repositories;
using Ecommerce_API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevController : ControllerBase
    {
        private readonly IDevRepo _repo;

        public DevController(IDevRepo repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllDev()
        {
            try
            {
                var data = await _repo.GetAllDev();
                return Ok(data);
            }
            catch
            {
                return BadRequest();
            }

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDev(string id)
        {
            try
            {
                var data = await _repo.GetDev(id);
                return Ok(data);

            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDev(string id, DeveloperVM model)
        {
            try
            {
                await _repo.UpdateDev(id, model);
                return Ok();

            }
            catch
            {
                return BadRequest();
            }

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> HideDev (string id)
        {
            var data = await _repo.HideDev(id);
            return Ok(data);
        }
        [HttpPost]
        public async Task<IActionResult> AddPub(DeveloperVM model)
        {
            try
            {
                var data = await _repo.AddDev(model);
                return Ok(data);
            }
            catch
            {
                return BadRequest();
            }

        }

    }

}
