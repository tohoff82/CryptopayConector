using CryptoPay.Connector.Models.Rest;
using CryptoPay.Connector.Utils;

using System.Threading.Tasks;

namespace CryptoPay.Connector
{
    public interface IPayConnector
    {
        Task<GetMeResponse> GetMeAsync();
        Task<GetBalanceResponse> GetBalanceAsync();
        Task<GetExchRatesResponse> GetExchangeRatesAsync();
        Task<GetCurrenciesResponse> GetCurrenciesAsync();

        Task<CreateInvoiceResponse> CreateInvoiceAsync(string asset, double amount, bool allowComments = false, bool allowAnanymous = false);
        Task<CreateInvoiceResponseWithPaidButton> CreateInvoiceAsync(string asset, double amount, PaidButtonType btnType, string btnUrl, bool allowComments = false, bool allowAnanymous = false);
        Task<CreateInvoiceResponseWithPayload> CreateInvoiceAsync(string asset, double amount, string payload, bool allowComments = false, bool allowAnanymous = false);
        Task<CreateInvoiceResponseWithPayloadDescription> CreateInvoiceAsync(string asset, double amount, string payload, string description, bool allowComments = false, bool allowAnanymous = false);
        Task<CreateInvoiceResponseWithPaidButtonAndPayload> CreateInvoiceAsync(string asset, double amount, PaidButtonType btnType, string btnUrl, string payload, bool allowComments = false, bool allowAnanymous = false);
        Task<CreateInvoiceResponseWithPaidButtonAndPayloadDescription> CreateInvoiceAsync(string asset, double amount, PaidButtonType btnType, string btnUrl, string payload, string description, bool allowComments = false, bool allowAnanymous = false);
    }
}
