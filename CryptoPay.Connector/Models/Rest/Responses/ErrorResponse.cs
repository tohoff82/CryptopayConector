using Cryptopay.Connector.Models.Value;
using Newtonsoft.Json;

namespace Cryptopay.Connector.Models.Rest.Responses;

internal class ErrorResponse
{
    /// <summary>
    /// Initializes an instance of ErrorResponse
    /// </summary>
    /// <param name="error">Instanse of Error
    public ErrorResponse(Error error)
    {
         Error = error;
    }

    [JsonConstructor]
    public ErrorResponse() {}

    /// <summary>
    /// Gets a value indicating whether the request was successful
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public bool Ok { get; init; } = false;
    
#nullable disable annotations
    /// <summary>
    /// Instance of Error
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public Error Error { get; init; }
#nullable enable annotations
}
