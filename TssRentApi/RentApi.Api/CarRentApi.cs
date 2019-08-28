using System.Threading.Tasks;
using RentApi.Shared.Request;
using RentApi.Shared.Response;

namespace RentApi.Api
{
    public class CarRentApi : ICarRentApi
    {
        private readonly IApiClient _api;
        private readonly string _token;

        public CarRentApi(IApiClient api, ITokenProvider tokenProvider)
        {
            _api = api;
            _token = tokenProvider.GetToken().Result;
        }

        public async Task<StationsResponse> GetStations(StationsRequest request)
        {
            var path = new Paths.Stations(_token);
            var response = await
                _api.CallRemoteApiAsync<StationsRequest, StationsResponse>(request, path);

            return response;
        }

        public async Task<SearchResponse> Search(SearchRequest request)
        {
            var path = new Paths.Search(_token);
            var response = await
                _api.CallRemoteApiAsync<SearchRequest, SearchResponse>(request, path);

            return response;
        }

        public async Task<ExtraResponse> GetExtra(ExtraRequest request)
        {
            var path = new Paths.Extra(_token);
            var response = await
                _api.CallRemoteApiAsync<ExtraRequest, ExtraResponse>(request, path);

            return response;
        }

        public async Task<ReserveResponse> Reserve(ReserveRequest request)
        {
            var path = new Paths.Reserve(_token);
            var response = await
                _api.CallRemoteApiAsync<ReserveRequest, ReserveResponse>(request, path);

            return response;
        }
    }
}