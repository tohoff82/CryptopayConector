using Cryptopay.Connector.Extensions;
using Cryptopay.Connector.Models.Rest.Requests;
using Cryptopay.Connector.Models.Value;
using Cryptopay.Connector.Utils;

namespace Cryptopay.Connector;

/// <inheritdoc />
internal class Cryptopay : ICryptopay
{
    /// <summary>
    /// Cryptopay API context
    /// </summary>
    private readonly ApiContext _apiContext;

    /// <summary>
    /// Initializes an instance of Cryptopay
    /// </summary>
    /// <param name="apiContext"></param>
    public Cryptopay(ApiContext apiContext)
    {
        _apiContext = apiContext;
    }

    public void Dispose()
        => _apiContext.Dispose();

    /// <inheritdoc />
    public long ApplicationId => _apiContext.GetConnectorId();

    /// <inheritdoc />
    public Task<CryptopayApp> GetMeAsync()
        => _apiContext.HttpGetAsync<CryptopayApp>(new GetMeRequest());

    /// <inheritdoc />
    public Task<IEnumerable<Balance>> GetBalancesAsync()
        => _apiContext.HttpGetAsync<IEnumerable<Balance>>(new GetBalancesRequest());

    /// <inheritdoc />
    public Task<IEnumerable<Currency>> GetCurrenciesAsync()
        => _apiContext.HttpGetAsync<IEnumerable<Currency>>(new GetCurrenciesRequest());

    /// <inheritdoc />
    public Task<IEnumerable<ExchangeRate>> GetExchangeRatesAsync()
        => _apiContext.HttpGetAsync<IEnumerable<ExchangeRate>>(new GetExchangeRatesRequest());

    /// <inheritdoc />
    public Task<Invoice> CreateInvoiceAsync(
        Assets  asset,
        decimal amount,
        string? description,
        string? hiddenMessage,
        PaidButtonNames paidBtnName,
        string? paidBtnUrl,
        string? payload,
        bool    allowComments,
        bool    allowAnonymous,
        int     expiresIn)
    => _apiContext.HttpPostAsync<Invoice>(
        new CreateInvoiceRequest(
            asset,
            amount,
            description,
            hiddenMessage,
            paidBtnName,
            paidBtnUrl,
            payload,
            allowComments,
            allowAnonymous,
            expiresIn));

    /// <inheritdoc />
    public Task<Invoices> GetInvoicesAsync(
        string[]? assets,
        int[]? invoiceIds,
        InvoiceTypes? status,
        int offset,
        int count)
    => _apiContext.HttpGetAsync<Invoices>(
        new GetInvoicesRequest(
            assets.ToCsvString(),
            invoiceIds.ToCsvString(),
            status, offset, count));

    /// <inheritdoc />
    public Task<Transfer> CreateTransferAsync(
        long    userId,
        Assets  asset,
        decimal amount,
        string  spendId,
        string? comment,
        bool?   disableSendNotification)
    => _apiContext.HttpPostAsync<Transfer>(
        new TransferRequest(
            userId,
            asset,
            amount,
            spendId,
            comment,
            disableSendNotification));
}
