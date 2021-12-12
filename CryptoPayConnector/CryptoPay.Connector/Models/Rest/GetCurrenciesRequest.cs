namespace CryptoPay.Connector.Models.Rest
{
    internal class GetCurrenciesRequest : ApiRequest
    {
        public GetCurrenciesRequest() : base()
            => Path.Append("/getCurrencies");
    }
}
