namespace CryptoPay.Connector.Models.Rest
{
    public class ErrorResponse : ApiResponse
    {
        public Error Error { get; set; }
    }

    public class Error
    {
        public int    Code { get; set; }
        public string Name { get; set; }
    }
}
