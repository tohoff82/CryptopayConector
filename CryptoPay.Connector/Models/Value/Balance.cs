using Cryptopay.Connector.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Cryptopay.Connector.Models.Value;

/// <summary>
/// Balance of your application
/// </summary>
[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class Balance
{
    /// <summary>
    /// Current currency
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public Assets CurrencyCode { get; init; }

    /// <summary>
    /// Amount of available coins
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public decimal Available { get; init; }
}
