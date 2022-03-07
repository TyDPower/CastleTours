using CastleTours.Shared.Models;

namespace CastleTours.Client.Services.AuthService
{
    public interface IAuthService
    {
        public bool UserAuthState { get; }
        Task<ServiceResponse<int>> Register(UserRegister request);
        Task<ServiceResponse<string>> Login(UserLogin request);
        Task GetUserAuthState();
    }
}
