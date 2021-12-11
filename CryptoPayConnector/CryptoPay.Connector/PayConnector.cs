using CryptoPay.Connector.Models.Rest;

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

    }
}
