namespace RentApi.Shared
{
    public class ExtraRequest
    {
        public ExtraRequest(string checkoutStation, string checkoutTime, string checkinStation, string checkinDate, string checkinTime, string contractId, string carCategoryCode, string checkoutDate)
        {
            CheckoutStation = checkoutStation;
            CheckinStation = checkinStation;
            
            CheckoutDate = checkoutDate.CheckDateFormat("yyyyMMdd");
            CheckoutTime = checkoutTime.CheckDateFormat("HHmm");
            CheckinDate = checkinDate.CheckDateFormat("yyyyMMdd");
            CheckinTime = checkinTime.CheckDateFormat("HHmm");

            ContractId = contractId;
            CarCategoryCode = carCategoryCode;
        }

        public string CheckoutStation { get; }
        public string CheckoutDate { get; }
        public string CheckoutTime { get; }
        public string CheckinStation { get; }
        public string CheckinDate { get; }
        public string CheckinTime { get; }
        public string ContractId { get; }
        public string CarCategoryCode { get; }


    }
}