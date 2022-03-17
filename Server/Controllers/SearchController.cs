using CastleTours.Server.Services.SearchService;
using CastleTours.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CastleTours.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        public ISearchService _searchService { get; }

        [HttpGet("locations")]
        public async Task<ActionResult<List<Location>>> LoadLocations()
        {
            return Ok(await _searchService.GetLocations());
        }

        [HttpGet("locations/areas")]
        public async Task<ActionResult<List<string>>> LoadLocationAreas()
        {
            return Ok(await _searchService.GetLocationAreas());
        }

        [HttpGet("facilities")]
        public async Task<ActionResult<List<Facility>>> LoadFacilities()
        {
            return Ok(await _searchService.GetFacilities());
        }

        [HttpGet("facilities/types")]
        public async Task<ActionResult<List<string>>> LoadFacilityTypes()
        {
            return Ok(await _searchService.GetFacilityTypes());
        }

        [HttpGet("categories")]
        public async Task<ActionResult<List<Category>>> LoadCategories()
        {
            return Ok(await _searchService.GetCategories());
        }

        [HttpGet("categories/names")]
        public async Task<ActionResult<List<string>>> LoadCategoryNames()
        {
            return Ok(await _searchService.GetCategoryNames());
        }
    }
}
