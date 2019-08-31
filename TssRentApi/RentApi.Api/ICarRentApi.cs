using System.Threading.Tasks;
using RentApi.Shared.Request;
using RentApi.Shared.Response;

namespace RentApi.Api
{
    public interface ICarRentApi
    {
        Task<StationsResponse> GetStations(StationsRequest request);
        Task<SearchResponse> Search(SearchRequest request);
        Task<ExtraResponse> GetExtra(ExtraRequest request);
        Task<ReserveResponse> Reserve(ReserveRequest request);
        Task<ConfirmResponse> Confirm(ConfirmRequest request);
    }
}