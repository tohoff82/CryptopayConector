using System.Text;
using Newtonsoft.Json;

namespace Cryptopay.Connector.Models.Rest.Requests;
/// <summary>
/// Base class for all API requests
/// </summary>
internal abstract class ApiRequest
{
    /// <summary>
    /// Endpoint path prefix
    /// </summary>
    private readonly string _api = "/api";

    /// <summary>
    /// Request data shema
    /// </summary>
    private const string _shema = "application/json";

    /// <summary>
    /// Builder for the request path
    /// </summary>
    /// <value></value>
    protected StringBuilder Path { get; set; }

    /// <summary>
    /// Request body object
    /// </summary>
    /// <value></value>
    protected object RequestBody { get; set; }

    /// <summary>
    /// Initialize base ApiRequest instance
    /// </summary>
    public ApiRequest()
    {
        Path = new StringBuilder(_api);
        RequestBody = new object();
    }

    /// <summary>
    /// Get request path
    /// </summary>
    /// <returns></returns>
    public Uri Uri
        => new Uri($"{Path}", UriKind.Relative);

    /// <summary>
    /// Get request body content with shema
    /// </summary>
    /// <returns></returns>
    public StringContent BodyContent
        => new StringContent(JsonConvert
            .SerializeObject(RequestBody),
                Encoding.UTF8, _shema);
}
