using CastleTours.Server.Data;
using CastleTours.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace CastleTours.Server.Services.FacilityService
{
    public class FacilityService : IFacilityService
    {
        private readonly DataContext _context;

        public FacilityService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Facility>> GetFacilities()
        {
            return await _context.Facilities.ToListAsync();
        }
    }
}
