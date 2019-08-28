using System.Threading.Tasks;

namespace RentApi.Api
{
    public interface IApiClient
    {
        TRes CallRemoteApi<TReq, TRes>(TReq request, ApiPathsBase path);
        Task<TRes> CallRemoteApiAsync<TReq, TRes>(TReq request, ApiPathsBase path);
    }
}