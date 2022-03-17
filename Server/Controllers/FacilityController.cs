using CastleTours.Server.Services.FacilityService;
using CastleTours.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CastleTours.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacilityController : ControllerBase
    {
        private readonly IFacilityService _facilityService;
        public FacilityController(IFacilityService facilityService)
        {
            _facilityService = facilityService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Facility>>> LoadFacilities()
        {
            var facilities = await _facilityService.GetFacilities();
            
            if (facilities == null) return NotFound();

            return Ok(facilities);
        }
    }
}
