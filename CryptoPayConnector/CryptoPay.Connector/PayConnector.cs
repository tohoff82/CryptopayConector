using CryptoPay.Connector.Models.Rest;
using CryptoPay.Connector.Utils;

using System.Net.Http;
using System.Threading.Tasks;

namespace CryptoPay.Connector
{
    public class PayConnector : IPayConnector
    {
        private readonly ApiContext _context;
        private readonly string     _token;

        internal PayConnector(ApiContext context, string token)
        {
            _context = context;
              _token = token;
        }

        public PayConnector(HttpClient httpClient, string token)
        {
            _context = new ApiContext(httpClient);
              _token = token;
        }

        public Task<GetMeResponse> GetMeAsync()
            => _context.HttpGetAsync<GetMeResponse>(new GetMeRequest(), _token);

        public Task<GetBalanceResponse> GetBalanceAsync()
            => _context.HttpGetAsync<GetBalanceResponse>(new GetBalanceRequest(), _token);

        public Task<GetExchRatesResponse> GetExchangeRatesAsync()
            => _context.HttpGetAsync<GetExchRatesResponse>(new GetExchRatesRequest(), _token);

        public Task<GetCurrenciesResponse> GetCurrenciesAsync()
            => _context.HttpGetAsync<GetCurrenciesResponse>(new GetCurrenciesRequest(), _token);


        public Task<CreateInvoiceResponse> CreateInvoiceAsync(string asset, double amount, bool allowComments = false, bool allowAnanymous = false)
            => _context.HttpPostAsync<CreateInvoiceResponse>(new CreateInvoiceRequest(asset, amount, allowComments, allowAnanymous), _token);

        public Task<CreateInvoiceResponseWithPaidButton> CreateInvoiceAsync(string asset, double amount, PaidButtonType btnType, string btnUrl, bool allowComments = false, bool allowAnanymous = false)
            => _context.HttpPostAsync<CreateInvoiceResponseWithPaidButton>(new CreateInvoiceRequest(asset, amount, btnType, btnUrl, allowComments, allowAnanymous), _token);

        public Task<CreateInvoiceResponseWithPayload> CreateInvoiceAsync(string asset, double amount, string payload, bool allowComments = false, bool allowAnanymous = false)
            => _context.HttpPostAsync<CreateInvoiceResponseWithPayload>(new CreateInvoiceRequest(asset, amount, payload, allowComments, allowAnanymous), _token);

        public Task<CreateInvoiceResponseWithPayloadDescription> CreateInvoiceAsync(string asset, double amount, string payload, string description, bool allowComments = false, bool allowAnanymous = false)
            => _context.HttpPostAsync<CreateInvoiceResponseWithPayloadDescription>(new CreateInvoiceRequest(asset, amount, payload, description, allowComments, allowAnanymous), _token);

        public Task<CreateInvoiceResponseWithPaidButtonAndPayload> CreateInvoiceAsync(string asset, double amount, PaidButtonType btnType, string btnUrl, string payload, bool allowComments = false, bool allowAnanymous = false)
            => _context.HttpPostAsync<CreateInvoiceResponseWithPaidButtonAndPayload>(new CreateInvoiceRequest(asset, amount, btnType, btnUrl, payload, allowComments, allowAnanymous), _token);

        public Task<CreateInvoiceResponseWithPaidButtonAndPayloadDescription> CreateInvoiceAsync(string asset, double amount, PaidButtonType btnType, string btnUrl, string payload, string description, bool allowComments = false, bool allowAnanymous = false)
            => _context.HttpPostAsync<CreateInvoiceResponseWithPaidButtonAndPayloadDescription>(new CreateInvoiceRequest(asset, amount, btnType, btnUrl, payload, description, allowComments, allowAnanymous), _token);
    }
}
