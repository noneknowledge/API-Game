using AutoMapper;
using Ecommerce_API.Models;
using Ecommerce_API.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Net.Mime;

namespace Ecommerce_API.Repositories
{
    public class AdminRepo: IAdminRepo
    {
        private readonly Game_DBContext _ctx;
        private readonly IMapper _mapper;

        public AdminRepo(Game_DBContext context, IMapper mapper) 
        {
            _ctx = context;
            _mapper = mapper;
        }

        public async Task<AdminVM> AddAdmin(AdminVM vm)
        {
            var model = _mapper.Map<Admin>(vm);
            model.AdminId = Guid.NewGuid().ToString();
            _ctx.Add(model);
            await _ctx.SaveChangesAsync();
            return vm;
        }

        public async Task DisableAdmin(string id)
        {
            var model = await _ctx.Admins.FirstOrDefaultAsync(a => a.AdminId == id);
            if (model.IsActive.ToUpper() == "TRUE")
                model.IsActive = "False";
            else
                model.IsActive = "True";
            _ctx.Update(model);
            await _ctx.SaveChangesAsync();
        }

        public async Task<AdminVM> GetAdmin(string id)
        {
            var model = await _ctx.Admins.FirstOrDefaultAsync(a=>a.AdminId == id);
            return _mapper.Map<AdminVM>(model);
        }

        public async Task<AdminVM> LoginAdmin(string username, string password)
        {
            var model = await _ctx.Admins.FirstOrDefaultAsync(a => a.AdName == username && a.PassWord == password);
            if (model != null) return _mapper.Map<AdminVM>(model);
            return null;
        }

        public async Task<AdminVM> UpdateAdmin(string id, AdminVM vm)
        {
            var model = await _ctx.Admins.FirstOrDefaultAsync(a => a.AdminId == id); 
            
            if (id == vm.AdminId)
            {
                var viewmodel = _mapper.Map<Admin>(vm);
                model = viewmodel;
                _ctx.Update(model);
                await _ctx.SaveChangesAsync();
                return vm;
            }
            return null;
        }
    }
}
