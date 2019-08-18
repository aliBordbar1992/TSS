namespace RentApi.Shared.Dto
{
    public class YesNoType : EnumType<YesNoType>, IDomainType
    {
        public static readonly YesNoType Yes = new YesNoType("Y");
        public static readonly YesNoType No = new YesNoType("N");

        public IDomainType Default => No;

        YesNoType(string code) : base(code)
        {
        }

        public string GetCode()
        {
            return Code;
        }
    }
}