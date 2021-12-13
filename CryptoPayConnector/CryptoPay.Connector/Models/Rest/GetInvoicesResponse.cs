using Newtonsoft.Json;

namespace CryptoPay.Connector.Models.Rest
{
    public class GetInvoicesResponse : ApiResponse
    {
        public InvoicesResult Result { get; set; }
    }

    public class InvoicesResult
    {
        [JsonProperty("items")]
        public Invoice[] Invoices { get; set; }
    }

    public class Invoice : CreatedInvoiceWithPaidButtonAndPayloadDescription
    {

    }
}
