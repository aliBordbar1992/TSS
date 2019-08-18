using System.Collections.Generic;
using RentApi.Shared.Dto;

namespace RentApi.Shared.Response
{
    public class ReserveResponse : BaseResponse
    {
        public List<ExtraResultItem> Results { get; set; }
    }
}