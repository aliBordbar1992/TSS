using System.Collections.Generic;
using RentApi.Shared.Dto;

namespace RentApi.Shared.Response
{
    public class ExtraResponse : BaseResponse
    {
        public ExtraResultItem Results { get; set; }
    }

    public class ConfirmResponse : BaseResponse
    {

    }
}