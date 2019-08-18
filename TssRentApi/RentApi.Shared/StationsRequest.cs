namespace RentApi.Shared
{
    public class StationsRequest
    {
        public string Content { get; }
        public string Country { get; set; }
        public AreaType AreaType { get; set; }

        public StationsRequest(string content)
        {
            Content = content;
        }
    }
}