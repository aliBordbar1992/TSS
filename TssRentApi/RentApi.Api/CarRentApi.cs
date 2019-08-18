using System.Threading.Tasks;
using RentApi.Shared.Request;
using RentApi.Shared.Response;

namespace RentApi.Api
{
    public interface ICarRentApi
    {
        Task<StationsResponse> GetStations(StationsRequest request);
    }
    public class CarRentApi : ICarRentApi
    {
        private readonly IApiClient _api;
        private readonly string _token;

        public CarRentApi(IApiClient api, IBaseUrl baseUrl, string token)
        {
            _api = api;
            _token = token;
            _api.SetBaseUrl(baseUrl.GetUrl());
        }

        public async Task<StationsResponse> GetStations(StationsRequest lfsOutboundRequest)
        {
            var path = new Paths.Stations(_token);
            var response = await
                _api.CallRemoteApiAsync<StationsRequest, StationsResponse>(lfsOutboundRequest, path);

            return response;
        }
    }
}