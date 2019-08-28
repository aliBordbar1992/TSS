using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RentApi.Shared.Dto;

namespace RentApi.Shared.Request
{
    public class ReserveRequest
    {
        public ReserveRequest(string checkoutStation, DateTime checkoutDateTime, string checkinStation,
            DateTime checkinDateTime, string contractId, string carCategoryCode, string rateId, string email,
            Driver driver)
        {
            CheckoutStation = checkoutStation;
            CheckoutDate = checkoutDateTime.ToString("yyyyMMdd");
            CheckoutTime = checkoutDateTime.ToString("HHmm");
            CheckinStation = checkinStation;
            CheckinDate = checkinDateTime.ToString("yyyyMMdd");
            CheckinTime = checkinDateTime.ToString("HHmm");
            ContractID = contractId;
            CarCategoryCode = carCategoryCode;
            RateId = rateId;
            Email = email;
            DriverString = driver.ToJsonString(new CamelCaseNamingStrategy());
        }

        public string CheckoutStation { get; }
        public string CheckoutDate { get; }
        public string CheckoutTime { get; }
        public string CheckinStation { get; }
        public string CheckinDate { get; }
        public string CheckinTime { get; }
        public string ContractID { get; }
        public string CarCategoryCode { get; }
        public string RateId { get; }
        public string FlightNumber { get; set; }
        public string Email { get; }

        [JsonProperty("driver")]
        public string DriverString { get; private set; }

        public List<string> Equipments { get; set; }
        public List<string> Optional { get; set; }
    }
}