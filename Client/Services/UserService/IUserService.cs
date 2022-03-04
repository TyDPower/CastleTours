using CastleTours.Shared.Models;

namespace CastleTours.Client.Services.UserService
{
    public interface IUserService
    {
        public User User { get; }
        Task GetUserDetailsFromDb();
        User GetUserDetails();
    }
}
