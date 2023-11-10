using Ecommerce_API.Models;
using Ecommerce_API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Mime;
using System.Net.WebSockets;

namespace Ecommerce_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly Game_DBContext _ctx;

        public LibraryController(Game_DBContext context)
        {
            _ctx = context;
        }
        [HttpGet("{uid}")]
        public async Task<IActionResult> GetLibrary(string uid)
        {
            var data = await _ctx.Libraries.Where(a => a.Uid == uid).ToListAsync();
            return Ok(data);
        }

        [HttpPost("{uid}")]
        public async Task<IActionResult> AddGameToLib(string uid, LibraryVM VM)
        {
            if (uid != VM.Uid)
            {
                return BadRequest();
            }
            var data = new Library();
            data.Uid = VM.Uid;
            data.GameId = VM.GameId;
            data.FeedBack = VM.FeedBack;
            _ctx.Add(data);
            await _ctx.SaveChangesAsync();
            return Ok(data);
        }
        [HttpPut()]
        public async Task<IActionResult> UpdateLibrary( LibraryVM vm)
        {
            var spec_game = await _ctx.Libraries.FirstOrDefaultAsync(a => a.Uid == vm.Uid && a.GameId == vm.GameId);
            if (spec_game == null) return BadRequest();
            spec_game.FeedBack = vm.FeedBack;
            return Ok(spec_game);
        }

    }
}
