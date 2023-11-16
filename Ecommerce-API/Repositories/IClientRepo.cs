using Ecommerce_API.ViewModels;

namespace Ecommerce_API.Repositories
{
    public interface IClientRepo
    {
        public Task<ClientVM> AddUser(ClientVM vm);
        public Task<ClientVM> UpdateUser(string id, ClientVM vm);
        public Task DisableUser(string id);
        public Task<ClientVM> GetUser(string id);
        public Task<ClientVM> LoginUser(LoginVM login);
    }
}
