﻿using CryptoPay.Connector.Models.Rest;
using CryptoPay.Connector.Utils;

using System.Net.Http;
using System.Threading.Tasks;

namespace CryptoPay.Connector
{
    public class PayConnector : IPayConnector
    {
        private readonly ApiContext _context;

        internal PayConnector(ApiContext context)
        {
            _context = context;
        }

        public PayConnector(HttpClient httpClient)
        {
            _context = new ApiContext(httpClient);
        }

        public Task<GetMeResponse> GetMeAsync()
            => _context.HttpGetAsync<GetMeResponse>(new GetMeRequest());

        public Task<GetBalanceResponse> GetBalanceAsync()
            => _context.HttpGetAsync<GetBalanceResponse>(new GetBalanceRequest());

        public Task<GetExchRatesResponse> GetExchangeRatesAsync()
            => _context.HttpGetAsync<GetExchRatesResponse>(new GetExchRatesRequest());

        public Task<GetCurrenciesResponse> GetCurrenciesAsync()
            => _context.HttpGetAsync<GetCurrenciesResponse>(new GetCurrenciesRequest());


        public Task<CreateInvoiceResponse> CreateInvoiceAsync(string asset, double amount, bool allowComments = false, bool allowAnanymous = false)
            => _context.HttpPostAsync<CreateInvoiceResponse>(new CreateInvoiceRequest(asset, amount, allowComments, allowAnanymous));

        public Task<CreateInvoiceResponseWithPaidButton> CreateInvoiceAsync(string asset, double amount, PaidButtonType btnType, string btnUrl, bool allowComments = false, bool allowAnanymous = false)
            => _context.HttpPostAsync<CreateInvoiceResponseWithPaidButton>(new CreateInvoiceRequest(asset, amount, btnType, btnUrl, allowComments, allowAnanymous));

        public Task<CreateInvoiceResponseWithPayload> CreateInvoiceAsync(string asset, double amount, string payload, bool allowComments = false, bool allowAnanymous = false)
            => _context.HttpPostAsync<CreateInvoiceResponseWithPayload>(new CreateInvoiceRequest(asset, amount, payload, allowComments, allowAnanymous));

        public Task<CreateInvoiceResponseWithPayloadDescription> CreateInvoiceAsync(string asset, double amount, string payload, string description, bool allowComments = false, bool allowAnanymous = false)
            => _context.HttpPostAsync<CreateInvoiceResponseWithPayloadDescription>(new CreateInvoiceRequest(asset, amount, payload, description, allowComments, allowAnanymous));

        public Task<CreateInvoiceResponseWithPaidButtonAndPayload> CreateInvoiceAsync(string asset, double amount, PaidButtonType btnType, string btnUrl, string payload, bool allowComments = false, bool allowAnanymous = false)
            => _context.HttpPostAsync<CreateInvoiceResponseWithPaidButtonAndPayload>(new CreateInvoiceRequest(asset, amount, btnType, btnUrl, payload, allowComments, allowAnanymous));

        public Task<CreateInvoiceResponseWithPaidButtonAndPayloadDescription> CreateInvoiceAsync(string asset, double amount, PaidButtonType btnType, string btnUrl, string payload, string description, bool allowComments = false, bool allowAnanymous = false)
            => _context.HttpPostAsync<CreateInvoiceResponseWithPaidButtonAndPayloadDescription>(new CreateInvoiceRequest(asset, amount, btnType, btnUrl, payload, description, allowComments, allowAnanymous));
    }
}
