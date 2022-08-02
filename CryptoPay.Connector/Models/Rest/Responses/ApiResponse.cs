using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Cryptopay.Connector.Models.Rest.Responses;

/// <summary>
/// Represents bot API response
/// </summary>
/// <typeparam name="T">Expected type of operation result</typeparam>
[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
internal class ApiResponse<T> where T : class
{
    /// <summary>
    /// Initializes an instance of ApiResponse{T}
    /// </summary>
    /// <param name="ok">Indicating whether the request was successful</param>
    /// <param name="result">Result object</param>
    public ApiResponse(bool ok, T result)
    {
            Ok = ok;
        Result = result;
    }

    [JsonConstructor]
    public ApiResponse() {}

    /// <summary>
    /// Gets a value indicating whether the request was successful
    /// </summary>
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool Ok { get; init; }

    /// <summary>
    /// Gets the result object
    /// </summary>
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    [MaybeNull]
    [AllowNull]
    public T Result { get; init; }
}
