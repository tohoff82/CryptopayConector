using Newtonsoft.Json;

namespace CryptoPay.Connector.Models.Rest.RequestBodies
{
    internal class GetInvoicesBody
    {
        [JsonProperty("asset")]
        public string Asset { get; set; }

        [JsonProperty("invoice_ids")]
        public string InvoiceId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("offset")]
        public ushort Offset { get; set; }

        [JsonProperty("count")]
        public ushort Count { get; set; }
    }
}
