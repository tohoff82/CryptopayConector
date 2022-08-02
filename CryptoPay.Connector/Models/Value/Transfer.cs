using Cryptopay.Connector.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Cryptopay.Connector.Models.Value;

/// <summary>
/// Transfer status
/// </summary>
[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class Transfer
{
    /// <summary>
    /// Unique ID for this transfer
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public long TransferId { get; set; }

    /// <summary>
    /// Telegram user ID the transfer was sent to
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public long UserId { get; set; }

    /// <summary>
    /// Currency code
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public Assets Asset { get; set; }

    /// <summary>
    /// Amount of the transfer
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public decimal Amount { get; set; }

    /// <summary>
    /// Status of the transfer, can be “completed”
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public TransferTypes Status { get; set; }

    /// <summary>
    /// Date the transfer was completed in ISO 8601 format
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public DateTime CompletedAt { get; set; }

#nullable disable warnings
    /// <summary>
    /// Comment for this transfer
    /// </summary>
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string Comment { get; set; }
#nullable restore warnings
}
