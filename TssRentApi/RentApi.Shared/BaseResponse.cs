using System.Collections.Generic;

namespace RentApi.Shared
{
    public class BaseResponse
    {
        public int ReseultCode { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
    }
}