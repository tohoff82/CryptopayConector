using System.Net;
using Cryptopay.Connector.Exceptions;
using Cryptopay.Connector.Extensions;
using Cryptopay.Connector.Models.Rest.Requests;
using Cryptopay.Connector.Models.Rest.Responses;
using Cryptopay.Connector.Models.Value;
using Newtonsoft.Json;

using static Cryptopay.Connector.Utils.Constants;

namespace Cryptopay.Connector;
/// <summary>
/// ApiContext instance to use in the application
/// </summary>
 internal class ApiContext : IDisposable
{
    /// <summary>
    /// Http client used to send requests to the API
    /// </summary>
    private readonly HttpClient _httpClient;

    /// <summary>
    /// Create ApiContext instance to use in the application
    /// </summary>
    /// <param name="httpClient"></param>
    public ApiContext(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    /// <summary>
    /// Dispose ApiContext instance
    /// </summary>
    public void Dispose()
    {
        _httpClient.Dispose();

        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Application ID derived from the token
    /// </summary>
    /// <returns></returns>
    internal long GetConnectorId()
    {
        var token = _httpClient.DefaultRequestHeaders.GetValues(AUTH_HEADER).SingleOrDefault();

        if (string.IsNullOrEmpty(token))
        {
            throw new CryptopayException("Authorization header is missing");
        }

        return token.ToApplicationId();
    }

    /// <summary>
    /// Get request to the API
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal async Task<T> HttpGetAsync<T>(ApiRequest request) where T : class
    {
        using var resp = await _httpClient
                .GetAsync(request.Uri).ConfigureAwait(false);

        return await UnpackAndGetResponse<T>(resp.Content, resp.StatusCode);
    }

    /// <summary>
    /// Post request to the API
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal async Task<T> HttpPostAsync<T>(ApiRequest request) where T : class
    {
        using var resp = await _httpClient
                .PostAsync(request.Uri, request.BodyContent)
                .ConfigureAwait(false);

        return await UnpackAndGetResponse<T>(resp.Content, resp.StatusCode);
    }

    private async Task<T> UnpackAndGetResponse<T>(HttpContent content, HttpStatusCode code) where T : class
    {
        string json = await content.ReadAsStringAsync();

        var jsonRes = JsonConvert.DeserializeObject<ApiResponse<T>>(json) ?? throw new CryptopayException(
            $"Request<{typeof(T).FullName}> returned an error:\n Responsed {nameof(json)} is null");

        if (!jsonRes.Ok)
        {
            var answ = JsonConvert.DeserializeObject<ErrorResponse>(json);

            throw new CryptopayException($"Request<{typeof(T).FullName}> returned an error:",
                new Error
                (   code: answ!.Error.Code,
                    name: answ.Error.Name
                ), code);
        }

        content.Dispose();

        return jsonRes.Result!;
    }
}
