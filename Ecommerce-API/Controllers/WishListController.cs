using Ecommerce_API.Models;
using Ecommerce_API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace Ecommerce_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WishListController : ControllerBase
    {
        private readonly Game_DBContext _ctx;

        public WishListController (Game_DBContext context)
        {
            _ctx = context;
        }
        [HttpGet("{uid}")]
        public async Task<IActionResult> GetWishList(string uid)
        {
            try
            {
                var data = _ctx.WishGames.Where(a => a.UID == uid).ToListAsync();
                return Ok(data);
            }
            catch
            {
                return BadRequest();
            }
            
        }
        [HttpPost]
        public async Task <IActionResult> AddWishList(WishListVM vm)
        {
            
                var data = new WishGame();
                data.GameId = vm.GameId;
                data.UID = vm.UID;
                _ctx.Add(data);
                await _ctx.SaveChangesAsync();
                return Ok(data);
            
            
        }
    }
}
