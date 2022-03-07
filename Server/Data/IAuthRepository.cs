using CastleTours.Shared.Models;

namespace CastleTours.Server.Data
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<ServiceResponse<int>> AddFavorite(Favorite favorite);
        Task<ServiceResponse<int>> RemoveFavorite(int tourId);
        Task<ServiceResponse<string>> Login(string email, string password);
        Task<bool> UserExists(string email);
    }
}
