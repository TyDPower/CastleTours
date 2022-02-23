using CastleTours.Shared.Models;

namespace CastleTours.Client.Services.UserService
{
    public interface IUserService
    {
        Task GetUserDetailsFromDb();
        User GetUserDetails();
    }
}
