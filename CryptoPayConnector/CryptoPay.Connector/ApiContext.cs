using CryptoPay.Connector.Models.Rest;

using Newtonsoft.Json;

using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CryptoPay.Connector
{
    public class ApiContext
    {
        private const string _authHeader = "Crypto-Pay-API-Token";
        private const string      _shema = "application/json";

        private readonly HttpClient _httpClient;

        public ApiContext(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        internal async Task<T> HttpGetAsync<T>(ApiRequest request, string token)
        {
            _httpClient.DefaultRequestHeaders.Add(_authHeader, token);

            var resp = await _httpClient.GetAsync(request.Uri).ConfigureAwait(false);

            if (!resp.IsSuccessStatusCode) throw new HttpRequestException($"{resp.StatusCode} : {resp.ReasonPhrase}");

            var unpckdResp = await UnpackAndGetResponse<T>(resp.Content);

            resp.Dispose();

            return unpckdResp;
        }

        internal async Task<T> HttpPostAsync<T>(ApiRequest request, string token)
        {
            _httpClient.DefaultRequestHeaders.Add(_authHeader, token);

            var resp = await _httpClient.PostAsync(request.Uri,
                new StringContent(request.JsonBody, Encoding.UTF8, _shema));

            var unpckdResp = await UnpackAndGetResponse<T>(resp.Content);

            resp.Dispose();

            return unpckdResp;
        }

        private async Task<T> UnpackAndGetResponse<T>(HttpContent content)
        {
            string json = await content.ReadAsStringAsync();

            content.Dispose();

            var packet = JsonConvert.DeserializeObject<ApiResponse>(json);

            if (!packet.IsOk)
            {
                var answ = JsonConvert.DeserializeObject<ErrorResponse>(json);

                throw new Exception($"code: {answ.Error.Code} : {answ.Error.Name}");
            }

            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
