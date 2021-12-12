using Newtonsoft.Json;

namespace CryptoPay.Connector.Models.Rest
{
    public class GetBalanceResponse : ApiResponse
    {
        public Balances[] Result { get; set; }
    }

    public class Balances
    {
        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        public decimal Available { get; set; }
    }
}
