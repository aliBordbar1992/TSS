using Microsoft.Extensions.DependencyInjection;

namespace RentApi.Api.Extensions
{
    public static class CarRentApiExtensions
    {
        public static void AddCarRentApi(this IServiceCollection serviceCollection, string username, string password)
        {
            string baseUrl = "http://tss.ir/rentapi";
            var url = new ApiBaseUrl { BaseUrl = baseUrl };
            serviceCollection.AddMemoryCache();
            serviceCollection.AddTransient<IBaseUrl>(c => url);
            serviceCollection.AddTransient<IApiClient, ApiClient>();
            serviceCollection.AddTransient<TokenConfiguration>(tc => new TokenConfiguration(username, password));
            serviceCollection.AddTransient<ITokenProvider, TokenProvider>();
            serviceCollection.AddTransient<ICarRentApi, CarRentApi>();
        }
    }
}