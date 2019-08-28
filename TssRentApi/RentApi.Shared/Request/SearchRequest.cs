using System;

namespace RentApi.Shared.Request
{
    public class SearchRequest
    {
        public string CheckoutStation { get; }
        public string CheckoutDate { get; }
        public string CheckoutTime { get; }
        public string CheckinStation { get; }
        public string CheckinDate { get; }
        public string CheckinTime { get; }

        public SearchRequest(string checkoutStation, DateTime checkoutDateTime, string checkinStation, DateTime checkinDateTime)
        {
            CheckoutStation = checkoutStation;
            CheckoutDate = checkoutDateTime.ToString("yyyyMMdd");
            CheckoutTime = checkoutDateTime.ToString("HHmm");
            CheckinStation = checkinStation;
            CheckinDate = checkinDateTime.ToString("yyyyMMdd");
            CheckinTime = checkinDateTime.ToString("HHmm");
        }
    }
}