using Ecommerce_API.Models;
using Ecommerce_API.ViewModels;

namespace Ecommerce_API.Repositories
{
    public interface ICategoriesRepo
    {
        public Task<List<CategoryVM>> GetAllCategories();
        public Task<Category?> GetCategoryById(string id);
        public Task<Category> AddCategory(CategoryVM category);
        public Task UpdateCategory(string id, Category category);
        
    }
}
