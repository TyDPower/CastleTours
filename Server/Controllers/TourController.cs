using CastleTours.Server.Services.TourService;
using CastleTours.Shared.Models;
using CastleTours.Shared.DTOModels;
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

        //DEPRICATED - Use SearchTours(null) to get all tours.
        /*[HttpGet]
        public async Task<ActionResult<List<Tour>>> GetAllTours()
        {
            return Ok(await _tourService.GetAllTours());
        }*/

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
        public async Task<ActionResult<ServiceResponse<List<SearchResult>>>> SearchTours(string searchText)
        {
            return Ok(await _tourService.SearchTours(searchText));
        }

        [HttpGet("search/new/{searchText}/{page}")]
        public async Task<ActionResult<ServiceResponse<TourSearchResult>>> SearchAllTours(int page = 1, string searchText = "castles")
        {
            return Ok(await _tourService.TourSearchResults(page, searchText));
        }

        [HttpGet("loadAll")]
        public async Task<ActionResult<ServiceResponse<List<SearchResult>>>> SearchAllTours()
        {
            return Ok(await _tourService.SearchTours(null));
        }

        [HttpGet("searchSuggestions/{searchText}")]
        public async Task<ActionResult<ServiceResponse<List<string>>>> GetTourSearchSuggestions(string searchText)
        {
            var result = await _tourService.GetTourSearchSuggestions(searchText);
            return Ok(result);
        }

        [HttpGet("featured")]
        public async Task<ActionResult<Tour>> GetFeaturedTour()
        {
            return Ok(await _tourService.GetFeaturedTour());
        }
    }
}
