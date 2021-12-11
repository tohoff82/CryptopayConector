using Newtonsoft.Json;

namespace CryptoPay.Connector.Models.Rest
{
    public class GetBalanceResponse : ApiResponse
    {
        public GetBalanceResult[] Result { get; set; }
    }

    public class GetBalanceResult
    {
        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        public decimal Available { get; set; }
    }
}
