using System.Threading.Tasks;

namespace RentApi.Api
{
    public interface ITokenProvider
    {
        Task<string> GetToken();
    }
}