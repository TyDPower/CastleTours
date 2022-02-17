using CastleTours.Server.Services.CastleService;
using CastleTours.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CastleTours.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastleController : ControllerBase
    {
        private readonly ICastleService _castleService;

        public CastleController(ICastleService castleService)
        {
            _castleService = castleService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Castle>>> GetAllCastles()
        {
            return Ok(await _castleService.GetAllCastles());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetCastleById(int id)
        {
            return Ok(await _castleService.GetCastleById(id));
        }
    }
}
