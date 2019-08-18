using System.Collections.Generic;
using RentApi.Shared.Dto;

namespace RentApi.Shared.Response
{
    public class SearchResponse : BaseResponse
    {
        public List<SearchResultItem> Results { get; set; }
    }
}