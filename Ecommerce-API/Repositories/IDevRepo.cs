using Ecommerce_API.Models;
using Ecommerce_API.ViewModels;

namespace Ecommerce_API.Repositories
{
    public interface IDevRepo
    {
        public Task<List<Developer>> GetAllDev();
        public Task<Developer?> GetDev(string id);
        public Task<Developer> AddDev(DeveloperVM category);
        public Task UpdateDev(string id, DeveloperVM category);
    }
}
