using Newtonsoft.Json;

namespace CryptoPay.Connector.Models.Rest
{
    public class GetExchRatesResponse : ApiResponse
    {
        public ExchangeRates[] Result { get; set; }
    }

    public class ExchangeRates
    {
        [JsonProperty("is_valid")]
        public bool IsValid { get; set; }

        public string Source { get; set; }
        public string Target { get; set; }
        public decimal  Rate { get; set; }
    }
}
