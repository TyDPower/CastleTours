using CastleTours.Server.Data;
using CastleTours.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace CastleTours.Server.Services.SearchService
{
    public class SearchService : ISearchService
    {
        public SearchService(DataContext context)
        {
            _context = context;
        }

        public DataContext _context { get; }

        public async Task<List<Location>> GetLocations()
        {
            return await _context.Locations.ToListAsync();
        }
        public async Task<List<string>> GetLocationAreas()
        {
            var items = await _context.Locations.ToListAsync();
            List<string> list = new List<string>();

            foreach (var i in items)
            {
                list.Add(i.Area);
            }

            return list;
        }

        public async Task<List<Category>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<List<string>> GetCategoryNames()
        {
            var categories = await _context.Categories.ToListAsync();
            List<string> list = new List<string>();

            foreach (var category in categories)
            {
                list.Add(category.Name);
            }

            return list;
        }

        public async Task<List<Facility>> GetFacilities()
        {
            return await _context.Facilities.ToListAsync();
        }

        public async Task<List<string>> GetFacilityTypes()
        {
            var items = await _context.Facilities.ToListAsync();
            List<string> list = new List<string>();

            foreach (var i in items)
            {
                list.Add(i.Type);
            }

            return list;
        }
    }
}
