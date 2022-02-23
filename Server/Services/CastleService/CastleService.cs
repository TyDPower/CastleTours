using CastleTours.Server.Data;
using CastleTours.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace CastleTours.Server.Services.CastleService
{
    public class CastleService : ICastleService
    {
        private readonly DataContext _context;

        public CastleService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Castle>> GetAllCastles()
        {
            return await _context.Castles.ToListAsync();
        }

        public async Task<Castle> GetCastleById(int id)
        {
            Castle castle = await _context.Castles
                .Include(c => c.Facilities)
                .Include(c => c.OperatingTimes)
                .Include(c => c.CastleComments)
                .Include(c => c.Location)
                .Include(c => c.Amenities)
                .FirstOrDefaultAsync(c => c.Id == id);
            return castle;
        }
    }
}
