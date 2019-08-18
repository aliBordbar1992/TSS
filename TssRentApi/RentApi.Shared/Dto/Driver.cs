namespace RentApi.Shared.Dto
{
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
        public string EuropCarId { get; set; }
    }
}