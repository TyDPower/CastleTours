using CastleTours.Shared.Models;
using System.Net.Http.Json;

namespace CastleTours.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>();
        public HttpClient Http { get; }

        public CategoryService(HttpClient http)
        {
            Http = http;
        }
        public async Task LoadCategories()
        {
            Categories = await Http.GetFromJsonAsync<List<Category>>("api/Category");
        }
    }
}
