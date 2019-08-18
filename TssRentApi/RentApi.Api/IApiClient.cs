using System.Threading.Tasks;

namespace RentApi.Api
{
    public interface IApiClient
    {
        TRes GetToken<TRes>(string username, string password);
        Task<TRes> GetTokenAsync<TRes>(string username, string password);

        TRes CallRemoteApi<TReq, TRes>(TReq request, ApiPathsBase path);
        Task<TRes> CallRemoteApiAsync<TReq, TRes>(TReq request, ApiPathsBase path);
        void SetBaseUrl(string url);
    }
}