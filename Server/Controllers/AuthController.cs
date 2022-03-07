using CastleTours.Server.Data;
using CastleTours.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CastleTours.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;

        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegister request)
        {
            var response = await _authRepo.Register(
                new User
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Email = request.Email,
                    MobileNumber = request.MobileNumber,
                    Bio = request.Bio,
                    DateOfBirth = request.DateOfBirth,
                    IsConfirmed = request.IsConfirmed,
                    ReadTsAndCs = request.ReadTsAndCs,
                    RecieveNewsletters = request.RecieveNewsletters,
                }, request.Password);

            if (!response.Success)
            { 
                return BadRequest(response);
            }

            return Ok(response);

        }

        [HttpPost("addFavorite")]
        public async Task<IActionResult> AddFavorite(Favorite favorite)
        {
            var response = await _authRepo.AddFavorite(favorite);

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpDelete("removeFavorite/{tourId}")]
        public async Task<IActionResult> RemoveFavorite(int tourId)
        {
            var response = await _authRepo.RemoveFavorite(tourId);

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLogin request)
        {
            var response = await _authRepo.Login(request.Email, request.Password);

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);

        }
    }
}
