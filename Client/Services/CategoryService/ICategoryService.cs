using CastleTours.Shared.Models;

namespace CastleTours.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        public List<Category> Categories { get; set; }
        Task LoadCategories();
    }
}
