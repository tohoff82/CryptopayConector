using Newtonsoft.Json;

namespace CryptoPay.Connector.Models.Rest
{
    public class GetCurrenciesResponse : ApiResponse
    {
        public Currencies[] Result { get; set; }
    }

    public class Currencies
    {
        [JsonProperty("is_blockchain")]
        public bool IsBlockchain { get; set; }

        [JsonProperty("is_stablecoin")]
        public bool IsStablecoin { get; set; }

        [JsonProperty("is_fiat")]
        public bool IsFiat { get; set; }

        public string Name { get; set; }
        public string Code { get; set; }
        public string  Url { get; set; }

        public byte Decimals { get; set; }
    }
}
