using Cryptopay.Connector.Models.Value;
using Cryptopay.Connector.Utils;

using static Cryptopay.Connector.Utils.Constants;

namespace Cryptopay.Connector;
/// <summary>
/// Cryptopay service class
/// </summary>
public interface ICryptopay : IDisposable
{
    /// <summary>
    /// Application identifier
    /// </summary>
    /// <value></value>
    long ApplicationId { get; }

    /// <summary>
    /// Get application information
    /// </summary>
    /// <returns></returns>
    Task<CryptopayApp> GetMeAsync();

    /// <summary>
    /// Get application balance information
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<Balance>> GetBalancesAsync();

    /// <summary>
    /// Get supported currencies
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<Currency>> GetCurrenciesAsync();

    /// <summary>
    /// Get current exchange rates
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<ExchangeRate>> GetExchangeRatesAsync();

    /// <summary>
    /// Create invoice
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
    /// <returns></returns>
    Task<Invoice> CreateInvoiceAsync(
        Assets  asset,
        decimal amount,
        string? description          = default,
        string? hiddenMessage        = default,
        PaidButtonNames paidBtnName  = default,
        string? paidBtnUrl           = default,
        string? payload              = default,
        bool    allowComments        = true,
        bool    allowAnonymous       = true,
        int     expiresIn            = EXPIRES_IN_MAX_SIZE);

    /// <summary>
    /// Get invoices list
    /// </summary>
    /// <param name="assets">Comma separated currency codes</param>
    /// <param name="invoiceIds">Comma separated id's of invoices</param>
    /// <param name="status">Type of invoices</param>
    /// <param name="offset">Offset</param>
    /// <param name="count">Count</param>
    /// <returns></returns>
    Task<Invoices> GetInvoicesAsync(
        string[]? assets       = default,
        int[]? invoiceIds      = default,
        InvoiceTypes? status   = default,
        int offset             = 0,
        int count              = 100);

    /// <summary>
    /// Transfer funds from one application to another
    /// </summary>
    /// <param name="userId">Telegram user ID, User must have previously used <c>@CryptoBot</c></param>
    /// <param name="asset">Currency code</param>
    /// <param name="amount">Currency amount</param>
    /// <param name="spendId">
    ///     Unique ID to make your request idempotent and ensure that only one of the transfers with the same <c>spendId</c> will be accepted by Crypto Pay API.
    ///     This parameter is useful when the transfer should be retried (i.e. request timeout, connection reset, 500 HTTP status, etc).
    ///     It can be some unique withdrawal identifier for example. Up to 64 symbols.
    /// </param>
    /// <param name="comment">Comment for the transfer. Users will see this comment when they receive a notification about the transfer. Up to 1024 symbols</param>
    /// <param name="disableSendNotification">Pass true if the user should not receive a notification about the transfer</param>
    /// <returns></returns>
    Task<Transfer> CreateTransferAsync(
          long  userId,
        Assets  asset,
        decimal amount,
        string  spendId,
        string? comment                 = default,
          bool? disableSendNotification = default);
}
