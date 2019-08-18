using System.Net.Http;

namespace RentApi.Api
{
    public class Paths
    {
        public class Login : ApiPathsBase
        {
            public Login()
            {
                HttpMethod = new HttpMethod("POST");
                Endpoint = "login";
            }
        }

        public class Stations : ApiPathsBase
        {
            public Stations(string token)
            {
                HttpMethod = new HttpMethod("POST");
                Endpoint = "getstations";
                Token = token;
            }
        }

        public class Search : ApiPathsBase
        {
            public Search(string token)
            {
                HttpMethod = new HttpMethod("POST");
                Endpoint = "search";
                Token = token;
            }
        }

        public class Extra : ApiPathsBase
        {
            public Extra(string token)
            {
                HttpMethod = new HttpMethod("POST");
                Endpoint = "getExtra";
                Token = token;
            }
        }

        public class Reserve : ApiPathsBase
        {
            public Reserve(string token)
            {
                HttpMethod = new HttpMethod("POST");
                Endpoint = "reserve";
                Token = token;
            }
        }
        
    }
}