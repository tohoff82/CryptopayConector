using CryptoPay.Connector.Extensions;
using CryptoPay.Connector.Utils;

using Newtonsoft.Json;

using System;

namespace CryptoPay.Connector.Models.Rest
{
    public class CreateInvoiceResponse : ApiResponse
    {
        public CreatedInvoice Result { get; set; }
    }

    public class CreateInvoiceResponseWithPaidButton : ApiResponse
    {
        public CreatedInvoiceWithPaidButton Result { get; set; }
    }

    public class CreateInvoiceResponseWithPayload : ApiResponse
    {
        public CreatedInvoiceWithPayload Result { get; set; }
    }

    public class CreateInvoiceResponseWithPayloadDescription : ApiResponse
    {
        public CreatedInvoiceWithPayloadDescription Result { get; set; }
    }

    public class CreateInvoiceResponseWithPaidButtonAndPayload : ApiResponse
    {
        public CreatedInvoiceWithPaidButtonAndPayload Result { get; set; }
    }

    public class CreateInvoiceResponseWithPaidButtonAndPayloadDescription : ApiResponse
    {
        public CreatedInvoiceWithPaidButtonAndPayloadDescription Result { get; set; }
    }

    public class CreatedInvoice
    {
        [JsonProperty("invoice_id")]
        public int Id { get; set; }

        [JsonProperty("status")]
        internal string InvStatus { get; set; }

        [JsonIgnore]
        public InvoiceStatus Status
            => InvStatus.ToEnum<InvoiceStatus>();

        [JsonProperty("pay_url")]
        public string PayUrl { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("allow_comments")]
        public bool AllowComments { get; set; }

        [JsonProperty("allow_anonymous ")]
        public bool AllowAnonymous { get; set; }

        public string    Hash { get; set; }
        public string   Asset { get; set; }
        public decimal Amount { get; set; }
    }

    public class CreatedInvoiceWithPaidButton : CreatedInvoice
    {
        [JsonProperty("paid_btn_name")]
        internal string PaidButtonName { get; set; }

        [JsonIgnore]
        public PaidButtonType PaidButton
            => !string.IsNullOrEmpty(PaidButtonName)
                ? PaidButtonName.ToEnum<PaidButtonType>()
                : PaidButtonType.None;

        [JsonProperty("paid_btn_url")]
        public string PaidButtonUrl { get; set; }
    }

    public class CreatedInvoiceWithPayload : CreatedInvoice
    {
        public string Payload { get; set; }
    }

    public class CreatedInvoiceWithPayloadDescription : CreatedInvoiceWithPayload
    {
        public string Description { get; set; }
    }

    public class CreatedInvoiceWithPaidButtonAndPayload : CreatedInvoiceWithPaidButton
    {
        public string Payload { get; set; }
    }

    public class CreatedInvoiceWithPaidButtonAndPayloadDescription : CreatedInvoiceWithPaidButtonAndPayload
    {
        public string Description { get; set; }
    }
}
