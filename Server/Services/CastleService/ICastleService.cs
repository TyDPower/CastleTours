using CastleTours.Shared.Models;

namespace CastleTours.Server.Services.CastleService
{
    public interface ICastleService
    {
        Task<List<Castle>> GetAllCastles();
        Task<Castle> GetCastleById(int id);
    }
}
