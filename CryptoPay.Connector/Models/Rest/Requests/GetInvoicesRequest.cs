using Cryptopay.Connector.Utils;

namespace Cryptopay.Connector.Models.Rest.Requests;

/// <summary>
/// GetInvoicesRequest class
/// </summary>
internal class GetInvoicesRequest : ApiRequest
{
    /// <summary>
    /// Initializes an instance of GetInvoicesRequest
    /// </summary>
    /// <param name="assets">Comma separated currency codes</param>
    /// <param name="invoiceIds">Comma separated id's of invoices</param>
    /// <param name="status">Type of invoices</param>
    /// <param name="offset">Offset</param>
    /// <param name="count">Count</param>
    public GetInvoicesRequest(
        string? assets,
        string? invoiceIds,
        InvoiceTypes? status,
        int offset,
        int count): base()
    {
        Path.Append("/getInvoices");

        RequestBody = new
        {
            assets       = assets,
            invoice_ids  = invoiceIds,
            status       = status?.ToString(),
            offset       = offset,
            count        = count
        };
    }
}
