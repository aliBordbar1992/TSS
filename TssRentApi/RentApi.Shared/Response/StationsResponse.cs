using System.Collections.Generic;
using RentApi.Shared.Dto;

namespace RentApi.Shared.Response
{
    public class StationsResponse : BaseResponse
    {
        public List<Station> Stations { get; set; }
    }
}