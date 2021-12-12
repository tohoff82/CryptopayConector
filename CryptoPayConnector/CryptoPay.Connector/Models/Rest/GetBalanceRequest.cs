namespace CryptoPay.Connector.Models.Rest
{
    internal class GetBalanceRequest : ApiRequest
    {
        public GetBalanceRequest() : base()
            => Path.Append("/getBalance");
    }
}
