using Newtonsoft.Json;
using RentApi.Shared.Dto;

namespace RentApi.Shared.Request
{
    public class StationsRequest
    {
        public string Content { get; }
        public string Country { get; set; }
        [JsonConverter(typeof(AreaTypeConverter))]
        public AreaType AreaType { get; set; }

        public StationsRequest(string content)
        {
            Content = content;
        }
    }
}