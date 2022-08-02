using Cryptopay.Connector.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace Cryptopay.Connector.Models.Value;

/// <summary>
/// All requests from Crypto Pay API has this JSON object
/// You can verify use method <see cref="Helper.CheckSignature" /> the received update and the integrity
/// of the received data by comparing the header parameter crypto-pay-api-signature
/// and the hexadecimal representation of HMAC-SHA-256 signature used to sign the entire request body
/// with a secret key that is SHA256 hash of your app's token.
/// </summary>
[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class Update
{
    /// <summary>
    /// Non-unique update ID
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public long UpdateId { get; init; }

    /// <summary>
    /// Webhook update type
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public UpdateTypes UpdateType { get; init; }

    /// <summary>
    /// Date the request was sent in ISO 8601 format
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public DateTime RequestDate { get; init; }

    /// <summary>
    /// Payload of the update
    /// </summary>
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public JObject? Payload { get; init; }

    /// <summary>
    /// Serialize object to string
    /// </summary>
    /// <returns></returns>
    public override string ToString()
         => JsonConvert.SerializeObject(this);
}
