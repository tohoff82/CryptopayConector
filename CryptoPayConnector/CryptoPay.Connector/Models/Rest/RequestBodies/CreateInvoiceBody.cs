using Newtonsoft.Json;

namespace CryptoPay.Connector.Models.Rest.RequestBodies
{
    internal class CreateInvoiceBodyBase
    {
        [JsonProperty("asset")]
        public string  Asset { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("allow_comments")]
        public bool AllowComments { get; set; }

        [JsonProperty("allow_anonymous ")]
        public bool AllowAnonymous { get; set; }
    }

    internal class CreateInvoiceBodyWithButton : CreateInvoiceBodyBase
    {
        [JsonProperty("paid_btn_name")]
        public string PaidButtonName { get; set; }

        [JsonProperty("paid_btn_url")]
        public string PaidButtonUrl { get; set; }
    }

    internal class CreateInvoiceBodyWithPayload : CreateInvoiceBodyBase
    {
        [JsonProperty("payload")]
        public string Payload { get; set; }
    }

    internal class CreateInvoiceBodyWithDescription : CreateInvoiceBodyWithPayload
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    internal class CreateInvoiceBodyWithButtonAndPayload : CreateInvoiceBodyWithButton
    {
        [JsonProperty("payload")]
        public string Payload { get; set; }
    }

    internal class CreateInvoiceBodyWithButtonAndDescription : CreateInvoiceBodyWithButtonAndPayload
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
