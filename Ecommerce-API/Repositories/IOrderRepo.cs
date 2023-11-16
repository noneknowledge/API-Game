
using Ecommerce_API.ViewModels;

namespace Ecommerce_API.Repositories
{
	public interface IOrderRepo
	{
		public Task<OrderVM> AddOrder(OrderVM model);
		public Task<OrderVM> GetOrder(string id);
		
	}
}
