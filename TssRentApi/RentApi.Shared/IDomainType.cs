namespace RentApi.Shared
{
    public interface IDomainType
    {
        IDomainType Default { get; }
        string GetCode();
    }
}