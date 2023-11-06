using AutoMapper;
using Ecommerce_API.Models;
using Ecommerce_API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_API.Repositories
{
    public class CategoriesRepo : ICategoriesRepo
    {
        private readonly Game_DBContext _context;
        private readonly IMapper _mapper;

        public CategoriesRepo(Game_DBContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Category> AddCategory(CategoryVM category)
        {
            var cate =  _mapper.Map<Category>(category);
            cate.CateId = Guid.NewGuid().ToString();
            _context.Add(cate);
            await _context.SaveChangesAsync();
            return cate;
        }

        public async Task<List<CategoryVM?>> GetAllCategories()
        {
            var cate = await _context.Categories.ToListAsync();
            
            return _mapper.Map<List<CategoryVM?>>(cate);

        }

        public async Task<Category?> GetCategoryById(string id)
        {
            var cate = await _context.Categories.FirstOrDefaultAsync(a => a.CateId == id);
            return cate == null ? null : cate;

        }

        public async Task UpdateCategory(string id, Category c)
        {
            if (id != c.CateId) return;
            var cate = await _context.Categories.FirstOrDefaultAsync(a => a.CateId == id);
            if (cate == null)
            {
                return ;
            }
            cate.CateDes = c.CateDes;
            cate.CateName = c.CateName;
            await _context.SaveChangesAsync();
            

        }
    }
}
