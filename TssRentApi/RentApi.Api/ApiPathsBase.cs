using System;
using System.Collections.Generic;
using System.Net.Http;

namespace RentApi.Api
{
    public class ApiPathsBase
    {
        protected ApiPathsBase()
        {
            HasCustomBaseUrl = false;
        }

        protected string UrlTemplate = "${path}/";
        protected HttpMethod HttpMethod;
        protected string Endpoint;
        protected string Token;
        public bool HasCustomBaseUrl { get; protected set; }

        public string GetUrl(string basePath)
        {
            return UrlTemplate
                .Replace("${path}", basePath);
        }
        public string GetToken()
        {
            return Token;
        }

        public HttpMethod GetHttpMethod()
        {
            return HttpMethod;
        }

        public string GetEndPoint()
        {
            return Endpoint;
        }

        public string GetEndPoint(List<Tuple<string, string>> param)
        {
            if (param != null)
            {
                foreach (var t in param)
                    Endpoint = Endpoint.Replace(t.Item1, t.Item2);
            }


            return (param != null) ? Endpoint : Endpoint + "/";
        }
    }
}
