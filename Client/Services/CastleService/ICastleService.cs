using CastleTours.Shared.Models;

namespace CastleTours.Client.Services.CastleService
{
    public interface ICastleService
    {
        List<Castle> Castles { get; set; }
        Task LoadCastles();
        Task<Castle> GetCastleById(int id);
    }
}
