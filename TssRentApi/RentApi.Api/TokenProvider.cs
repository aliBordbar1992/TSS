using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using RentApi.Shared.Request;
using RentApi.Shared.Response;

namespace RentApi.Api
{
    public class TokenConfiguration
    {
        public readonly string Username;
        public readonly string Password;

        public TokenConfiguration(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }

    public class TokenProvider : ITokenProvider
    {
        private readonly IMemoryCache _cache;
        private readonly IApiClient _client;
        private readonly TokenConfiguration _tokenConfigs;

        public TokenProvider(IMemoryCache cache, IApiClient client, TokenConfiguration tokenConfigs)
        {
            _cache = cache;
            _client = client;
            _tokenConfigs = tokenConfigs;
        }
        public async Task<string> GetToken()
        {
            if (!_cache.TryGetValue("_Token", out string token))
            {
                var t = await GetTokenAsync<LoginResponse>(_tokenConfigs.Username, _tokenConfigs.Password);

                token = t.Token;

                MemoryCacheEntryOptions opt = new MemoryCacheEntryOptions();
                opt.AbsoluteExpiration = DateTime.Now.AddSeconds(3600);

                _cache.Set("_Token", token, opt);
            }

            return token;
        }

        private async Task<TRes> GetTokenAsync<TRes>(string username, string password)
        {
            var path = new Paths.Login();
            return await _client.CallRemoteApiAsync<LoginRequest, TRes>(new LoginRequest(username, password), path);
        }


    }
}