using CastleTours.Shared.Models;

namespace CastleTours.Server.Services.FacilityService
{
    public interface IFacilityService
    {
        Task<List<Facility>> GetFacilities();
    }
}
