using Cryptopay.Connector.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Cryptopay.Connector.Models.Value;

/// <summary>
/// Invoice model
/// </summary>
[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class Invoice
{
    /// <summary>
    /// Unique ID for this invoice
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public long InvoiceId { get; init; }

    /// <summary>
    /// Status of the invoice, can be either “active”, “paid” or “expired”
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public InvoiceTypes Status { get; init; }

#nullable disable warnings
    /// <summary>
    /// Hash of the invoice
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public string Hash { get; init; }

    /// <summary>
    /// URL should be presented to the user to pay the invoice
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public string PayUrl { get; init; }
#nullable restore warnings

    /// <summary>
    /// Date the invoice was created in ISO 8601 format
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public DateTime CreatedAt { get; init; }
    /// <summary>
    /// Currency code
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    [JsonConverter(typeof(StringEnumConverter))]
    public Assets Asset { get; init; }

    /// <summary>
    /// Amount of the invoice
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public double Amount { get; init; }

    /// <summary>
    /// True, if the user can pay the invoice anonymously
    /// </summary>
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? AllowAnonymous { get; init; }

    /// <summary>
    /// Optional. Date the invoice expires in Unix time
    /// </summary>
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public DateTime? ExpirationDate { get; init; }

    /// <summary>
    /// Date the invoice was paid in Unix time
    /// </summary>
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public DateTime? PaidAt { get; init; }

    /// <summary>
    /// True, if the invoice was paid anonymously
    /// </summary>
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? PaidAnonymously { get; init; }

#nullable disable warnings
    /// <summary>
    /// Comment to the payment from the user
    /// </summary>
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string Comment { get; init; }

    /// <summary>
    /// Description for this invoice
    /// </summary>
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string Description { get; init; }

    /// <summary>
    /// Text of the hidden message for this invoice
    /// </summary>
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string HiddenMessage { get; init; }

    /// <summary>
    ///  Previously provided data for this invoice
    /// </summary>
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string Payload { get; init; }
    /// <summary>
    ///  URL of the button
    /// </summary>
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string PaidBtnUrl { get; init; }
#nullable restore warnings

    /// <summary>
    ///  Name of the button, can be one of "viewItem", "openChannel", "openBot" or "callback"
    /// </summary>
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public PaidButtonNames? PaidBtnName { get; init; }

    /// <summary>
    /// True, if the user can add comment to the payment
    /// </summary>
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool? AllowComments { get; init; }

}
