using AutoMapper;
using Ecommerce_API.Models;
using Ecommerce_API.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_API.Repositories
{
	public class GameRepo : IGameRepo
	{
		private readonly Game_DBContext _ctx;
		private readonly IMapper _mapper;

		public GameRepo(Game_DBContext context, IMapper mapper)
		{
			_ctx = context;
			_mapper = mapper;
		}
		public async Task<Game> AddGame(GameVM vm)
		{
			var game = _mapper.Map<Game>(vm);
			game.IsActive = "True";
			if (game.ReleaseDate == null) game.ReleaseDate = DateTime.Now.Date;
			game.View = 0;

			_ctx.Add(game);
			await _ctx.SaveChangesAsync();

			return game;
		}

		public async Task<List<Game>> GetAllGame()
		{
			var data = await _ctx.Games.ToListAsync();
			return data;

		}

		public async Task<Game> GetGame(string id)
		{
			var data = await _ctx.Games.FirstOrDefaultAsync(a => a.GameId == id);
			return data;
		}

		public async Task<Game> HideGame(string id)
		{
			var data = await _ctx.Games.FirstOrDefaultAsync(a => a.GameId == id);
			if (data.IsActive.ToUpper() == "TRUE") data.IsActive = "False";
			else data.IsActive = "True";
			_ctx.Update(data);
			await _ctx.SaveChangesAsync();
			return data;
		}

		public Task<Game> UpdateGame(GameVM vm)
		{
			throw new NotImplementedException();
		}
	}
}
