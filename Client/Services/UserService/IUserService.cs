using CastleTours.Shared.Models;

namespace CastleTours.Client.Services.UserService
{
    public interface IUserService
    {
        event Action OnChange;
        public User User { get; }
        Task GetUserDetailsFromDb();
        User GetUserDetails();
        Task<List<Favorite>> GetUserFavorites();
        Task<Favorite> GetUserFavorite(int tourId);
        Task<ServiceResponse<int>> AddFavorite(Favorite favorite);
        Task<ServiceResponse<int>> RemoveFavorite(int tourId);
    }
}
