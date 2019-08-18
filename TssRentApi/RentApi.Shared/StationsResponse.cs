using System.Collections.Generic;

namespace RentApi.Shared
{
    public class StationsResponse : BaseResponse
    {
        public List<Station> Stations { get; set; }
    }
}