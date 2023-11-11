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

        public WishListController(Game_DBContext context)
        {
            _ctx = context;
        }
        [HttpGet("{uid}")]
        public async Task<IActionResult> GetWishList(string uid)
        {
            try
            {
                var data = _ctx.ShoppingCarts.Where(a => a.Uid == uid).ToListAsync();
                return Ok(data);
            }
            catch
            {
                return BadRequest();
            }

        }
        [HttpDelete]
        public async Task<IActionResult> RemoveItem(WishListVM vm)
        {
            try
            {
                var data = _ctx.ShoppingCarts.Where(a => a.Uid == vm.UID && a.GameId == vm.GameId);
                _ctx.Remove(data);
                await _ctx.SaveChangesAsync();
                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddWishList(WishListVM vm)
        {

            var data = new ShoppingCart();
            data.GameId = vm.GameId;
            data.Uid = vm.UID;
            _ctx.Add(data);
            await _ctx.SaveChangesAsync();
            return Ok(data);


        }
    }
}
