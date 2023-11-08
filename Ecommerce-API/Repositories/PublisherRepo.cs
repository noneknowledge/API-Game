﻿using AutoMapper;
using Ecommerce_API.Models;
using Ecommerce_API.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_API.Repositories
{
    public class PublisherRepo : IPublisherRepo
    {
        private readonly Game_DBContext _context;
        private readonly IMapper _mapper;

        public PublisherRepo(Game_DBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        public async Task<Publisher> AddPublisher(PublisherVM category)
        {
            var model = _mapper.Map<Publisher>(category);
            model.PublisherId = Guid.NewGuid().ToString();
            model.IsActive = "True";
            _context.Add(model);
            await _context.SaveChangesAsync();
            return model;

        }

        public async Task<List<Publisher>> GetAllPublisher()
        {
            var model = await _context.Publishers.ToListAsync();
            return model;
        }

        public async Task<Publisher?> GetPublisher(string id)
        {
            var model = await _context.Publishers.FirstOrDefaultAsync(a => a.PublisherId == id);
            return model;
        }

        public async Task UpdatePublisher(string id, PublisherVM category)
        {
            var model = await _context.Publishers.FirstOrDefaultAsync(a => a.PublisherId == id);
            model.Description = category.Description;
            model.Publisher1 = category.Publisher1;
        }
    }
}