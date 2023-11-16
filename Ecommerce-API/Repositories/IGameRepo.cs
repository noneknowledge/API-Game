using Ecommerce_API.Models;
using Ecommerce_API.ViewModels;

namespace Ecommerce_API.Repositories
{
	public interface IGameRepo
	{
		public Task<List<Game>> GetAllGame();
		public Task<Game> GetGame (string id);
		public Task<Game> AddGame(GameVM vm);
		public Task<Game> UpdateGame( GameVM vm);
		public Task<Game> HideGame(string id);

	}
}
