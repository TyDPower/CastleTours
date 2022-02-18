using CastleTours.Server.Data;
using CastleTours.Server.Services.CategoryService;
using CastleTours.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace CastleTours.Server.Services.TourService
{
    public class TourService : ITourService
    {
        private readonly ICategoryService _categoryService;
        private readonly DataContext _context;

        public TourService(ICategoryService categoryService, DataContext context)
        {
            _categoryService = categoryService;
            _context = context;
        }

        public async Task<List<Tour>> GetAllTours()
        {
            return await _context.Tours.ToListAsync();
        }

        public async Task<Tour> GetTourById(int id)
        {
            Tour tour = await _context.Tours
                .Include(t => t.Castle)
                .Include(t => t.Castle.Location)
                .Include(t => t.Addons)
                .Include(t => t.Facilities)
                .FirstOrDefaultAsync(t => t.Id == id);
            return tour;
        }

        public async Task<List<Tour>> GetToursByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return await _context.Tours.Where(t => t.CategoryId == category.Id).ToListAsync();
        }
    }
}
