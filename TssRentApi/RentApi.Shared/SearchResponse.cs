using System.Collections.Generic;

namespace RentApi.Shared
{
    public class SearchResponse : BaseResponse
    {
        public List<SearchResultItem> Results { get; set; }
    }
}