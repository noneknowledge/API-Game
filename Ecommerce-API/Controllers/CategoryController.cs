using Ecommerce_API.Models;
using Ecommerce_API.Repositories;
using Ecommerce_API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoriesRepo _cateRepo;

        public CategoryController(ICategoriesRepo repo)
        {
            _cateRepo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            try
            {
                return Ok(await _cateRepo.GetAllCategories());
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(string id)
        {
            return Ok(await _cateRepo.GetCategoryById(id));
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(string id, Category c)
        {
            await _cateRepo.UpdateCategory(id, c);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryVM c)
        {
            await _cateRepo.AddCategory(c);
            return RedirectToAction(nameof(GetAllCategories));
        }
    }

}
