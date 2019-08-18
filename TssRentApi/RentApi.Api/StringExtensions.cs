using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace RentApi.Api
{
    public static class StringExtensions
    {
        public static string ToJsonString(this object inp)
        {
            return JsonConvert.SerializeObject(
                inp
                , Formatting.None
                , new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    ContractResolver = new DefaultContractResolver()
                    {
                        NamingStrategy = new SnakeCaseNamingStrategy()
                    }
                });
        }

        public static T ToObject<T>(this string jsonString)
        {
            return JsonConvert.DeserializeObject<T>(jsonString, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Include,
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new SnakeCaseNamingStrategy()
                }
            });
        }

    }
}