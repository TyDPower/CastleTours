using CastleTours.Server.Services.TourService;
using CastleTours.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CastleTours.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TourController : ControllerBase
    {
        private readonly ITourService _tourService;

        public TourController(ITourService tourService)
        {
            _tourService = tourService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Tour>>> GetAllTours()
        {
            return Ok(await _tourService.GetAllTours());
        }

        [HttpGet("Category/{categoryUrl}")]
        public async Task<ActionResult<List<Tour>>> GetToursByCategory(string categoryUrl)
        {
            return Ok(await _tourService.GetToursByCategory(categoryUrl));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tour>> GetTourById(int id)
        {
            return Ok(await _tourService.GetTourById(id));
        }

        [HttpGet("search/{searchText}")]
        public async Task<ActionResult<List<Tour>>> SearchTours(string searchText)
        {
            return Ok(await _tourService.SearchTours(searchText));
        }

        [HttpGet("featured")]
        public async Task<ActionResult<Tour>> GetFeaturedTour()
        {
            return Ok(await _tourService.GetFeaturedTour());
        }
    }
}
