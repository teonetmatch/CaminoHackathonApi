using System.Threading.Tasks;
using Cmp.Services.Accommodation.V2;
using CaminoHackathonApi.Models;

namespace CaminoHackathonApi.Services
{
    /// <summary>
    /// Wraps the generated gRPC client call.
    /// </summary>
    public interface IAccommodationSearchService
    {
        Task<AccommodationSearchResponse> SearchAsync(AccommodationSearchRequestDto dto);
    }
}
