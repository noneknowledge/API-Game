using Ecommerce_API.ViewModels;

namespace Ecommerce_API.Repositories
{
    public interface IAdminRepo
    {
        public Task<AdminVM> AddAdmin(AdminVM vm);
        public Task<AdminVM> UpdateAdmin(string id, AdminVM vm);
        public Task DisableAdmin(string id);
        public Task<AdminVM> GetAdmin(string id);
        public Task<AdminVM> LoginAdmin(LoginVM vm);
    }
}
