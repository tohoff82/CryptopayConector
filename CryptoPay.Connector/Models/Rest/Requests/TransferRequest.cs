using Cryptopay.Connector.Utils;

namespace Cryptopay.Connector.Models.Rest.Requests;

/// <summary>
/// TransferRequest class
/// </summary>
internal class TransferRequest : ApiRequest
{
    /// <summary>
    /// Initializes an instance of TransferRequest
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
    public TransferRequest(
        long userId,
        Assets asset,
        decimal amount,
        string spendId,
        string? comment,
        bool? disableSendNotification) : base()
    {
        Path.Append("/transfer");

        RequestBody = new
        {
            user_id         = userId,
            asset           = $"{asset}",
            amount          = amount,
            spend_id        = spendId,
            comment         = comment,
            disable_send_notification = disableSendNotification
        };
    }
}
