using CastleTours.Server.Data;
using CastleTours.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace CastleTours.Server.Services.OperatingTimesService
{
    public class OperatingTimesService : IOperatingTimesService
    {
        private readonly DataContext Context;

        public OperatingTimesService(DataContext context)
        {
            Context = context;
        }

        public async Task<List<OperatingTime>> GetOperatingTimesByCastleId(int castleId)
        {
            return await Context.OperatingTimes.Where(ot => ot.CastleId == castleId).ToListAsync();
        }

        public async Task<List<OperatingTime>> GetOperatingTimesByTourId(int tourId)
        {
            return await Context.OperatingTimes.Where(ot => ot.TourId == tourId).ToListAsync();
        }
    }
}
