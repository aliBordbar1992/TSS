namespace RentApi.Shared.Dto
{
    public class CarCategoryStatusType : EnumType<CarCategoryStatusType>, IDomainType
    {
        public static readonly CarCategoryStatusType FreeSell = new CarCategoryStatusType("F");
        public static readonly CarCategoryStatusType OnRequest = new CarCategoryStatusType("R");

        public IDomainType Default => FreeSell;

        CarCategoryStatusType(string code) : base(code)
        {
        }

        public string GetCode()
        {
            return Code;
        }
    }
}