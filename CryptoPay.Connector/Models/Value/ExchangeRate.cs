using Cryptopay.Connector.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Cryptopay.Connector.Models.Value;

/// <summary>
/// Exchange rates of supported currencies
/// </summary>
[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class ExchangeRate
{
    /// <summary>
    /// Is valid
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public bool IsValid { get; init; }

    /// <summary>
    /// Suurce currency
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public Assets Source { get; init; }

    /// <summary>
    /// Exchange rate
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public decimal Rate { get; init; }

#nullable disable warnings
    /// <summary>
    /// Target currency
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public string Target { get; init; }
#nullable restore warnings
}
