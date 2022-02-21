using CastleTours.Server.Data;
using CastleTours.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace CastleTours.Server.Services.StatsService
{
    public class StatsService : IStatsService
    {
        private readonly DataContext Context;

        public StatsService(DataContext context)
        {
            Context = context;
        }
        public async Task<int> GetVisits()
        {
            var stats = await Context.Stats.FirstOrDefaultAsync();
            if (stats == null)
            {
                return 0;
            }

            return stats.Visits;
        }

        public async Task IncrementVisits()
        {
            var stats = await Context.Stats.FirstOrDefaultAsync();
            if (stats == null)
            {
                Context.Stats.Add( new Stats { Visits = 1, LastVisit = DateTime.Now });
            }
            else
            {
                stats.Visits++;
                stats.LastVisit = DateTime.Now;
            }

            await Context.SaveChangesAsync();
        }
    }
}
