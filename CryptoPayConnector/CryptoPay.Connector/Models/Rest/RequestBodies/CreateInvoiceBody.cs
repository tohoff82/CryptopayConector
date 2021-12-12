using Newtonsoft.Json;

namespace CryptoPay.Connector.Models.Rest.RequestBodies
{
    internal class CreateInvoiceBodyBase
    {
        public string  Asset { get; set; }
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
        public string Payload { get; set; }
    }

    internal class CreateInvoiceBodyWithDescription : CreateInvoiceBodyWithPayload
    {
        public string Description { get; set; }
    }

    internal class CreateInvoiceBodyWithButtonAndPayload : CreateInvoiceBodyWithButton
    {
        public string Payload { get; set; }
    }

    internal class CreateInvoiceBodyWithButtonAndDescription : CreateInvoiceBodyWithButtonAndPayload
    {
        public string Description { get; set; }
    }
}
