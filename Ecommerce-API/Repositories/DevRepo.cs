﻿using AutoMapper;
using Ecommerce_API.Models;
using Ecommerce_API.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_API.Repositories
{
    public class DevRepo : IDevRepo
    {
        private readonly Game_DBContext _context;
        private readonly IMapper _mapper;

        public DevRepo(Game_DBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Developer> AddDev(DeveloperVM category)
        {
            var model = _mapper.Map<Developer>(category);
            model.DevId = Guid.NewGuid().ToString();
            model.IsActive = "True";
            _context.Add(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<List<Developer>> GetAllDev()
        {
            var model = await _context.Developers.ToListAsync();
            return model;
        }

        public async Task<Developer?> GetDev(string id)
        {
            var model = await _context.Developers.FirstOrDefaultAsync(a => a.DevId == id);
            return model;
        }

        public async Task UpdateDev(string id, DeveloperVM category)
        {
            var model = await _context.Developers.FirstOrDefaultAsync(a => a.DevId == id);
            model.Description = category.Description;
            model.Developer1 = category.Developer1;
        }
    }
}