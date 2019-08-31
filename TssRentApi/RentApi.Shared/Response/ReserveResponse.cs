using System.Collections.Generic;
using Newtonsoft.Json;
using RentApi.Shared.Dto;

namespace RentApi.Shared.Response
{
    public class ReserveResponse : BaseResponse
    {
        public long Result { get; set; }
        [JsonProperty("resultcode")]
        public long ResultCode { get; set; }
        public ReserveResult Results { get; set; }
    }

}