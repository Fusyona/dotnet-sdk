
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Fusyona.Nft.Models;

[DataContract]
public class SingleToken
{
    /// <summary>
    /// The token
    /// </summary>
    [DataMember(Name = "token", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "token")]
    public Token? Token { get; set; }

    /// <summary>
    /// The collection of the token
    /// </summary>
    [DataMember(Name = "collection", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "collection")]
    public Collection? Collection { get; set; }

    /// <summary>
    /// Attributes of the token
    /// </summary>
    [DataMember(Name = "attributes", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "attributes")]
    public List<string>? Attributes { get; set; }

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        // var sb = new StringBuilder();
        // sb.Append("class nft{");
        // sb.Append("  TokenId ").Append(TokenId).Append("\n");
        // sb.Append("}");

        // return sb.ToString();

        return this.ToJson();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson()
    {
        return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
