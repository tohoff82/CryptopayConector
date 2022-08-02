using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Cryptopay.Connector.Models.Value;

/// <summary>
/// Basic information about an application.
/// </summary>
[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class CryptopayApp
{
    /// <summary>
    /// Your application Id
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public long AppId { get; init; }

#nullable disable warnings
    /// <summary>
    /// Your application Name
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public string Name { get; init; }

    /// <summary>
    /// Payment processing bot username, main or test bot username
    /// </summary>
    [JsonProperty(Required = Required.Default)]
    public string PaymentProcessingBotUsername { get; init; }
#nullable restore warnings
}
