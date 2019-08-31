using System.Collections.Generic;

namespace RentApi.Shared.Response
{
    public class BaseResponse
    {
        public int ResultCode { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
    }
}