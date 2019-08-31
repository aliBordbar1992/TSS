namespace RentApi.Shared.Request
{
    public class ConfirmRequest
    {
        public ConfirmRequest(int reserveId)
        {
            ReserveId = reserveId;
        }
        public int ReserveId { get; private set; }
    }
}