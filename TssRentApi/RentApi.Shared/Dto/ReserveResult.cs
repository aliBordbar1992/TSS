using Newtonsoft.Json;

namespace RentApi.Shared.Dto
{
    public class ReserveResult
    {
        public int ReserveId { get; set; }
        public long Price { get; set; }
        public long Warranty { get; set; }
        [JsonProperty("totalprice")]
        public long TotalPrice { get; set; }
    }
}
