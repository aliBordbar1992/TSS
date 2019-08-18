using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using RentApi.Shared.Request;

namespace RentApi.Api
{
    public class ApiClient : IApiClient
    {
        private string _baseUrl;


        public ApiClient()
        {
        }

        public TRes GetToken<TRes>(string username, string password)
        {
            return GetTokenAsync<TRes>(username, password).Result;
        }

        public async Task<TRes> GetTokenAsync<TRes>(string username, string password)
        {
            var path = new Paths.Login();
            return await CallRemoteApiAsync<LoginRequest, TRes>(new LoginRequest(username, password), path);
        }


        public TRes CallRemoteApi<TReq, TRes>(TReq request, ApiPathsBase path)
        {
            return CallRemoteApiAsync<TReq, TRes>(request, path).Result;
        }


        public async Task<TRes> CallRemoteApiAsync<TReq, TRes>(TReq request, ApiPathsBase path)
        {
            TRes response;

            using (var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip }))
            {
                SetupClient(client, path);

                response = await ProcessRequestAsync<TReq, TRes>(client, request, path);
            }

            return response;
        }




        #region AsyncMethods

        private async Task<TRes> ProcessRequestAsync<TReq, TRes>(HttpClient client, TReq request, ApiPathsBase path)
        {
            string uri = path.GetEndPoint();

            HttpResponseMessage resp = null;

            if (request == null) throw new Exception($"Object request can't be null in a {path.GetHttpMethod()} request");

            if (path.GetHttpMethod() == HttpMethod.Post)
            {
                string objectSerialized = request.ToJsonString();
                var contentToSend = new StringContent(objectSerialized, Encoding.UTF8, "application/json");

                resp = await ProcessPostRequestAsync(contentToSend, path, client);
            }

            if (resp == null) throw new HttpRequestException($"{path.GetHttpMethod()} is not a valid request.");

            string result = await resp.Content.ReadAsStringAsync();
            var response = result.ToObject<TRes>();
            return response;
        }

        private async Task<HttpResponseMessage> ProcessPostRequestAsync(StringContent contentToSend, ApiPathsBase path, HttpClient client)
        {
            return await client.PostAsync(path.GetEndPoint(), contentToSend);
        }

        #endregion


        private void SetupClient(HttpClient client, ApiPathsBase path)
        {
            client.BaseAddress = new Uri(path.GetUrl(_baseUrl));

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Client-Token", path.GetToken());
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");
        }
        public void SetBaseUrl(string url)
        {
            _baseUrl = url;
        }
    }
}