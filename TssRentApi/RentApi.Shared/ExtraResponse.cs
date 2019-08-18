using System.Collections.Generic;

namespace RentApi.Shared
{
    public class ExtraResponse : BaseResponse
    {
        public List<ExtraResultItem> Results { get; set; }
    }
}