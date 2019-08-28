using Newtonsoft.Json;

namespace RentApi.Shared.Dto
{
    public class SearchResultItem
    {
        [JsonConverter(typeof(EnumTypeConverter<YesNoType>))]
        public YesNoType CarCategoryAirCond { get; set; }
        [JsonConverter(typeof(EnumTypeConverter<YesNoType>))]
        public YesNoType CarCategoryAutomatic { get; set; }
        public string CarCategoryBaggageQuantity { get; set; }
        public string CarCategoryCode { get; set; }
        public string CarCategoryDoors { get; set; }
        public string CarCategoryName { get; set; }
        public string CarCategorySample { get; set; }
        public string CarCategorySeats { get; set; }
        [JsonConverter(typeof(EnumTypeConverter<CarCategoryStatusType>))]
        public CarCategoryStatusType CarCategoryStatusCode { get; set; }
        public string ContractId { get; set; }
        public string Currency { get; set; }
        public string IncludedKm { get; set; }
        public string RateId { get; set; }
        public string MinAgeForCategory { get; set; }
        public string MinLicencePeriod { get; set; }
        public string YoungDriverAge { get; set; }
        public string CarFuelType { get; set; }
        public int CurrencyValue { get; set; }
        public int Price { get; set; }
        public string Pic { get; set; }
    }
}