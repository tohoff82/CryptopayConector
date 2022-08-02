using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Cryptopay.Connector.Models.Value;

/// <summary>
/// List of nvoice
/// </summary>
[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class Invoices
{
    /// <summary>
    /// List of Invoice
    /// </summary>
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public IEnumerable<Invoice>? Items { get; init; }
}
