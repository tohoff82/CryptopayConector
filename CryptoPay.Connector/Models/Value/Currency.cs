using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Cryptopay.Connector.Models.Value;

/// <summary>
/// Supported currencies
/// </summary>
[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class Currency
{
    /// <summary>
    /// Is blockchain
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public bool IsBlockchain { get; init; }

    /// <summary>
    /// Is stablecoin
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    // ReSharper disable once IdentifierTypo
    public bool IsStablecoin { get; init; }

    /// <summary>
    /// Ordinary currency
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public bool IsFiat { get; init; }

#nullable disable warnings
    /// <summary>
    /// Name of currency
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public string Name { get; init; }

    /// <summary>
    /// Code of currency
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    // [JsonConverter(typeof(StringEnumConverter))]
    // public Assets Code { get; init; }
    public string Code { get; init; }
#nullable restore warnings

    /// <summary>
    /// Number of decimal places
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public int Decimals { get; init; }

    /// <summary>
    ///  Url 
    /// </summary>
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string? Url { get; init; }
}
