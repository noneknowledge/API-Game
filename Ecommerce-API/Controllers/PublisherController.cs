using Ecommerce_API.Repositories;
using Ecommerce_API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        private readonly IPublisherRepo _repo;

        public PublisherController(IPublisherRepo repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllPub()
        {
            try
            {
                var data = await _repo.GetAllPublisher();
                return Ok(data);
            }
            catch
            {
                return BadRequest();
            }

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPub(string id)
        {
            try
            {
                var data = await _repo.GetPublisher(id);
                return Ok(data);

            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePub(string id, PublisherVM model)
        {
            try
            {
                await _repo.UpdatePublisher(id, model);
                return Ok();

            }
            catch
            {
                return BadRequest();
            }

        }
        [HttpPost]
        public async Task<IActionResult> AddPub(PublisherVM model)
        {
            try
            {
                var data = await _repo.AddPublisher(model);
                return Ok(data);
            }
            catch
            {
                return BadRequest();
            }

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> HidePubliser(string id)
        {
            try
            {
                var data = await _repo.HidePublisher(id);
                return Ok(data);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
