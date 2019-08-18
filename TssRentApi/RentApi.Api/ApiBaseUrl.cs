namespace RentApi.Api
{
    public class ApiBaseUrl : IBaseUrl
    {
        public string BaseUrl { get; set; }
        public string GetUrl()
        {
            return BaseUrl;
        }

        public void SetUrl(string url)
        {
            BaseUrl = url;
        }
    }
}