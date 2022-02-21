using CastleTours.Server.Services.StatsService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CastleTours.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatsController : ControllerBase
    {
        private readonly IStatsService StatsService;

        public StatsController(IStatsService statsService)
        {
            StatsService = statsService;
        }

        [HttpGet]
        public async Task<ActionResult<int>> GetVisits()
        {
            return await StatsService.GetVisits();
        }

        [HttpPost]
        public async Task IncrementVisits()
        {
            await StatsService.IncrementVisits();
        }
    }
}
