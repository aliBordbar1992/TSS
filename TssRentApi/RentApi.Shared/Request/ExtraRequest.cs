using System;
using RentApi.Shared.Dto;

namespace RentApi.Shared.Request
{
    public class ExtraRequest
    {
        public ExtraRequest(string checkoutStation, DateTime checkoutDateTime, string checkinStation, DateTime checkinDateTime, string contractId, string carCategoryCode)
        {
            CheckoutStation = checkoutStation;
            CheckinStation = checkinStation;
            
            CheckoutDate = checkoutDateTime.ToString("yyyyMMdd");
            CheckoutTime = checkoutDateTime.ToString("HHmm");
            CheckinDate = checkinDateTime.ToString("yyyyMMdd");
            CheckinTime = checkinDateTime.ToString("HHmm");

            ContractID = contractId;
            CarCategoryCode = carCategoryCode;
        }

        public string CheckoutStation { get; }
        public string CheckoutDate { get; }
        public string CheckoutTime { get; }
        public string CheckinStation { get; }
        public string CheckinDate { get; }
        public string CheckinTime { get; }
        public string ContractID { get; }
        public string CarCategoryCode { get; }


    }
}