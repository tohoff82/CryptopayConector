using Newtonsoft.Json;

namespace CryptoPay.Connector.Models.Rest
{
    public class ApiResponse
    {
        [JsonProperty("ok")]
        public bool IsOk { get; set; }
    }
}
