using AutoMapper;
using Ecommerce_API.Models;
using Ecommerce_API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Mime;

namespace Ecommerce_API.Repositories
{
	public class OrderRepo : IOrderRepo
	{
		private readonly IMapper _mapper;
		private readonly Game_DBContext _ctx;

		public OrderRepo(Game_DBContext context , IMapper mapper)
		{
			_mapper = mapper;
			_ctx = context;
		}

		public async Task<OrderVM> AddOrder(OrderVM model)
		{
			var data = _mapper.Map<Order>(model);
			data.OrderId = Guid.NewGuid().ToString();
			data.OrderDate = DateTime.Now.Date;
			_ctx.Add(data);
			await _ctx.SaveChangesAsync();
			return model;
		}

		public async Task<OrderVM> GetOrder(string id)
		{
			var data = await _ctx.Orders.FirstOrDefaultAsync(a => a.OrderId == id);
			var viewmodel = _mapper.Map<OrderVM>(data);
			return viewmodel;

		}
	}
}
