using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace RentApi.Shared
{
    public static class StringExtensions
    {
        public static string ToJsonString(this object inp, NamingStrategy namingStrategy)
        {
            return JsonConvert.SerializeObject(
                inp
                , Formatting.None
                , new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    ContractResolver = new DefaultContractResolver()
                    {
                        NamingStrategy = namingStrategy
                    }
                });
        }

        public static T ToObject<T>(this string jsonString, NamingStrategy namingStrategy)
        {
            return JsonConvert.DeserializeObject<T>(jsonString, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Include,
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = namingStrategy
                }
            });
        }

    }
}