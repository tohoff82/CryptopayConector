using Newtonsoft.Json;

namespace CryptoPay.Connector.Models.Rest
{
    public class GetMeResponse : ApiResponse
    {
        public GetMeResult Result { get; set; }
    }

    public class GetMeResult
    {
        [JsonProperty("app_id")]
        public int AppId { get; set; }

        [JsonProperty("payment_processing_bot_username")]
        public string ProcessingUsername { get; set; }

        public string Name { get; set; }
    }
}
