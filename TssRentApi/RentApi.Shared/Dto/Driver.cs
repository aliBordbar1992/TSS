using Newtonsoft.Json;

namespace RentApi.Shared.Dto
{
    public class Driver
    {
        public Driver(string mobile, string title, string firstNameEn, string lastNameEn, string nationalCode, string address)
        {
            Mobile = mobile;
            Title = title;
            FirstNameEn = firstNameEn;
            LastNameEn = lastNameEn;
            NationalCode = nationalCode;
            Address = address;
        }

        public string Mobile { get; }
        public string Title { get; }
        [JsonProperty("firstName_en")]
        public string FirstNameEn { get; }
        [JsonProperty("lastName_en")]
        public string LastNameEn { get; }
        [JsonProperty("firstName_fa")]
        public string FirstNameFa { get; set; }
        [JsonProperty("lastName_fa")]
        public string LastNameFa { get; set; }
        [JsonProperty("europcarid")]
        public string EuropCarId { get; set; }

        public string NationalCode { get; set; }
        public string Address { get; set; }
    }
}