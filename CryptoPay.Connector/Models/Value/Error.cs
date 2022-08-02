using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Cryptopay.Connector.Models.Value;

/// <summary>
/// Error from response
/// </summary>
[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class Error
{
    /// <summary>
    /// Create instance of Error
    /// </summary>
    /// <param name="code"></param>
    /// <param name="name"></param>
    public Error(int code, string name)
    {
        Code = code;
        Name = name;
    }
    
    [JsonConstructor]
    private Error() {}

    /// <summary>
    /// Error code from response
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public int Code { get; set; }

#nullable disable annotations
    /// <summary>
    /// Error name from response
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public string Name { get; set; }
#nullable restore annotations
}