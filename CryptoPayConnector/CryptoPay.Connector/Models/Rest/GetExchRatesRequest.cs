namespace CryptoPay.Connector.Models.Rest
{
    internal class GetExchRatesRequest : ApiRequest
    {
        public GetExchRatesRequest() : base()
            => Path.Append("/getExchangeRates");
    }
}
