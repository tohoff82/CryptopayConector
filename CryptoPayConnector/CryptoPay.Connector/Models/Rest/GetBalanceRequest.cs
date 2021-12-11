namespace CryptoPay.Connector.Models.Rest
{
    public class GetBalanceRequest : ApiRequest
    {
        public GetBalanceRequest() : base()
            => Path.Append("/getBalance");
    }
}
