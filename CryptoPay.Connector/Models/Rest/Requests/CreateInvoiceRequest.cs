using Cryptopay.Connector.Utils;

namespace Cryptopay.Connector.Models.Rest.Requests;

/// <summary>
/// CreateInvoiceRequest class
/// </summary>
internal class CreateInvoiceRequest : ApiRequest
{
    /// <summary>
    /// Initializes an instance of CreateInvoiceRequest
    /// </summary>
    /// <param name="asset">Currency code</param>
    /// <param name="amount">Currency amount</param>
    /// <param name="description">Description for this invoice</param>
    /// <param name="hiddenMessage">Text of the hidden message for this invoice</param>
    /// <param name="paidBtnName">Name of the button, can be one of "viewItem", "openChannel", "openBot" or "callback"</param>
    /// <param name="paidBtnUrl">URL of the button</param>
    /// <param name="payload">Previously provided data for this invoice</param>
    /// <param name="allowComments">True, if the user can add comment to the payment</param>
    /// <param name="allowAnonymous">True, if the user can pay the invoice anonymously</param>
    /// <param name="expiresIn">Expires in second</param>
    public CreateInvoiceRequest(
        Assets asset,
        decimal amount,
        string? description,
        string? hiddenMessage,
        PaidButtonNames paidBtnName,
        string? paidBtnUrl,
        string? payload,
        bool allowComments,
        bool allowAnonymous,
        int expiresIn) : base()
    { 
        Path.Append("/createInvoice");

        RequestBody = new
        {
            asset           = asset.ToString(),
            amount          = amount,
            description     = description,
            hidden_message  = hiddenMessage,
            paid_btn_name   = paidBtnName.ToString(),
            paid_btn_url    = paidBtnUrl,
            payload         = payload,
            allow_comments  = allowComments,
            allow_anonymous = allowAnonymous,
            expires_in      = expiresIn
        };
    }
}
