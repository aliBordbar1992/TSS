using System.Collections.Generic;

namespace RentApi.Shared
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
        public List<Equipment> Equipments { get; set; }
        public List<Option> Optional { get; set; }
    }

    public class Driver
    {
        public Driver(string mobile, string title, string firstNameEn, string lastNameEn)
        {
            Mobile = mobile;
            Title = title;
            FirstNameEn = firstNameEn;
            LastNameEn = lastNameEn;
        }

        public string Mobile { get; }
        public string Title { get; }
        public string FirstNameEn { get; }
        public string LastNameEn { get; }
        public string FirstNameFa { get; set; }
        public string LastNameFa { get; set; }
        public string EuropcarId { get; set; }
    }
}