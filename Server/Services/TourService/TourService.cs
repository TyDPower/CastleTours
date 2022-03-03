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

        private async Task<List<Tour>> FindToursBySearchText(string searchText)
        {
            return await _context.Tours
                .Where(t => t.Name.ToLower().Contains(searchText.ToLower())
                || t.Description.Contains(searchText.ToLower())
                || t.Castle.Name.Contains(searchText.ToLower())
                || t.Castle.Location.Area.Contains(searchText.ToLower()))
                .Include(t => t.Castle)
                .Include(t => t.Castle.Location)
                .Include(t => t.Addons)
                .Include(t => t.Facilities)
                .Include(t => t.OperatingTimes)
                .Include(t => t.TourComments)
                .ToListAsync();
        }

        private async Task<List<Tour>> GetAllTours()
        {
            return await _context.Tours
                .Include(t => t.Castle)
                .Include(t => t.Castle.Location)
                .Include(t => t.Facilities)
                .Include(t => t.Addons)
                .Include(t => t.TourComments)
                .ToListAsync();
        }

        public async Task<Tour> GetTourById(int id)
        {
            Tour tour = await _context.Tours
                .Include(t => t.Castle)
                .Include(t => t.Castle.Location)
                .Include(t => t.Addons)
                .Include(t => t.Facilities)
                .Include(t => t.OperatingTimes)
                .Include(t => t.TourComments)
                .FirstOrDefaultAsync(t => t.Id == id);
            return tour;
        }

        public async Task<List<Tour>> GetToursByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return await _context.Tours.Where(t => t.CategoryId == category.Id).ToListAsync();
        }

        public async Task<ServiceResponse<List<SearchResult>>> SearchTours(string searchText = null)
        {
            ServiceResponse<List<Tour>> response;

            if (searchText != null)
            {
                response = new ServiceResponse<List<Tour>>
                {
                    Data = await FindToursBySearchText(searchText)
                };
            }
            else
            {
                response = new ServiceResponse<List<Tour>>
                {
                    Data = await GetAllTours()
                };
            }
            
            List<SearchResult> searchResults = new List<SearchResult>();

            foreach (var i in response.Data)
            {
                var searchResult = new SearchResult()
                {
                    Id = i.Id,
                    Title = i.Name,
                    Rating = i.GetTourRating(),
                    Blurb = i.Blurb,
                    Location = i.Castle.Location.GetFormattedLocation(),
                    ImgUrl = i.ImgUrl,
                    Facilities = i.Facilities,
                };

                searchResults.Add(searchResult);
            }

            return new ServiceResponse<List<SearchResult>> { Data = searchResults };
        }

        public async Task<ServiceResponse<List<string>>> GetTourSearchSuggestions(string searchText)
        {
            var tours = await FindToursBySearchText(searchText);

            List<string> result = new List<string>();

            foreach (var tour in tours)
            {
                if (tour.Name.ToLower().Contains(searchText.ToLower()))
                {
                    result.Add(tour.Name);
                }

                if (tour.Castle.Name.ToLower().Contains(searchText.ToLower()))
                {
                    result.Add(tour.Castle.Name);
                }

                if (tour.Castle.Location.Area.ToLower().Contains(searchText.ToLower()))
                {
                    result.Add(tour.Castle.Location.Area);
                }

                if (tour.Description.ToLower().Contains(searchText.ToLower()))
                {
                    result.Add(tour.Description);
                }
            }

            return new ServiceResponse<List<string>> { Data = result };
        }

        public async Task<FeaturedTour> GetFeaturedTour()
        {
            var tours = await _context.Tours.Include(t => t.Castle)
                .Include(t => t.Castle.Location)
                .Include(t => t.TourComments)
                .ToListAsync();
            var tour = tours.Where(t => t.IsFeatured).FirstOrDefault();

            string corporateBasePrice = (tour.Price * 10).ToString("0.00"); //Change the hard coded '10' to a variable loaded for a storeConfig file

            FeaturedTour featuredTour = new()
            {
                TourId = tour.Id,
                TourName = tour.Name,
                TourImageUrl = tour.ImgUrl,
                TourBlurb = tour.Blurb,
                TourBasePrice = tour.GetTicketPriceFormatted(),
                TourRating = tour.GetTourRating(),
                CastleId = tour.Castle.Id,
                CastleName = tour.Castle.Name,
                CorporateBasePrice = corporateBasePrice
            };

            return featuredTour;
        }
        
    }
}
