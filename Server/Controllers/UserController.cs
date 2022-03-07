using CastleTours.Server.Data;
using CastleTours.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace CastleTours.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        public UserController(DataContext context)
        {
            Context = context;
        }

        public DataContext Context { get; }

        [HttpGet("getuserdetails")]
        public async Task<IActionResult> GetUserDetails()
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var user = await Context.Users
                .Include(u => u.Favorites)
                .FirstOrDefaultAsync(u => u.Id == userId);

            return Ok(user);
        }

        [HttpGet("getUserFavorites")]
        public async Task<IActionResult> GetUserFavorites()
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var favorites = await Context.Favorites.Where(f => f.UserId == userId).ToListAsync();

            return Ok(favorites);
        }

        [HttpGet("getUserFavoriteById/{tourId}")]
        public async Task<IActionResult> GetUserFavorite(int tourId)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var favorite = await Context.Favorites.Where(f => f.TourId == tourId && f.UserId == userId)
                .FirstOrDefaultAsync();

            return Ok(favorite);
        }

        
    }
}
