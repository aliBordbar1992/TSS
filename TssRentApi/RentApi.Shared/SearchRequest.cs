namespace RentApi.Shared
{
    public class SearchRequest
    {
        public string CheckoutStation { get; }
        public string CheckoutDate { get; }
        public string CheckoutTime { get; }
        public string CheckinStation { get; }
        public string CheckinDate { get; }
        public string CheckinTime { get; }

        public SearchRequest(string checkoutStation, string checkoutDate, string checkoutTime, string checkinStation, string checkinDate, string checkinTime)
        {
            CheckoutStation = checkoutStation;
            CheckoutDate = checkoutDate;
            CheckoutTime = checkoutTime;
            CheckinStation = checkinStation;
            CheckinDate = checkinDate;
            CheckinTime = checkinTime;
        }
    }
}