using AutoMapper;
using Ecommerce_API.Models;
using Ecommerce_API.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_API.Repositories
{
    public class ClientRepo: IClientRepo
    {
        private readonly Game_DBContext _ctx;
        private readonly IMapper _mapper;

        public ClientRepo(Game_DBContext context, IMapper mapper)
        {
            _ctx = context;
            _mapper = mapper;
        }

        public async Task<ClientVM> AddUser(ClientVM vm)
        {
            var model = _mapper.Map<Client>(vm);
            model.Uid = Guid.NewGuid().ToString();
            _ctx.Add(model);
            await _ctx.SaveChangesAsync();
            return vm;
        }

        public async Task DisableUser(string id)
        {
            var model = await _ctx.Clients.FirstOrDefaultAsync(a => a.Uid == id);
            if (model.IsActive.ToUpper() == "TRUE")
                model.IsActive = "False";
            else
                model.IsActive = "True";
            _ctx.Update(model);
            await _ctx.SaveChangesAsync();
        }

        public async Task<ClientVM> GetUser(string id)
        {
            var model = await _ctx.Admins.FirstOrDefaultAsync(a => a.AdminId == id);
            return _mapper.Map<ClientVM>(model);
        }

        public async Task<ClientVM> LoginUser(string username, string password)
        {
            var model = await _ctx.Clients.FirstOrDefaultAsync(a => a.UserName == username && a.PassWord == password);
            if (model != null) return _mapper.Map<ClientVM>(model);
            return null;
        }

        public async Task<ClientVM> UpdateUser(string id, ClientVM vm)
        {
            var model = await _ctx.Clients.FirstOrDefaultAsync(a => a.Uid == id);

            if (id == vm.Uid)
            {
                var viewmodel = _mapper.Map<Client>(vm);
                model = viewmodel;
                _ctx.Update(model);
                await _ctx.SaveChangesAsync();
                return vm;
            }
            return null;
        }
    }
}

