using System.Collections.Generic;
using RentApi.Shared.Dto;

namespace RentApi.Shared.Request
{
    public class ReserveRequest
    {
        public ReserveRequest(string checkoutStation, string checkoutDate, string checkoutTime, string checkinStation,
            string checkinDate, string checkinTime, string contractId, string carCategoryCode, string rateId,
            string flightNumber, string email)
        {
            CheckoutStation = checkoutStation;
            CheckoutDate = checkoutDate;
            CheckoutTime = checkoutTime;
            CheckinStation = checkinStation;
            CheckinDate = checkinDate;
            CheckinTime = checkinTime;
            ContractId = contractId;
            CarCategoryCode = carCategoryCode;
            RateId = rateId;
            FlightNumber = flightNumber;
            Email = email;
        }

        public string CheckoutStation { get; }
        public string CheckoutDate { get; }
        public string CheckoutTime { get; }
        public string CheckinStation { get; }
        public string CheckinDate { get; }
        public string CheckinTime { get; }
        public string ContractId { get; }
        public string CarCategoryCode { get; }
        public string RateId { get; }
        public string FlightNumber { get; }
        public string Email { get; }
        public List<Driver> Driver { get; set; }
        public List<string> Equipments { get; set; }
        public List<string> Optional { get; set; }
    }
}