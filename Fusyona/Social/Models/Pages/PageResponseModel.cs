using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Fusyona.Social.Models;

[DataContract]
public class PageResponseModel
{
    /// <summary>
    /// Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "id")]
    public string?  Id{ get; set; }

    /// <summary>
    /// Title
    /// </summary>
    [DataMember(Name = "title", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "title")]
    public string?  Title{ get; set; }

    /// <summary>
    /// Description
    /// </summary>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "description")]
    public string?  Description{ get; set; }

    /// <summary>
    /// Followers
    /// </summary>
    [DataMember(Name = "followers", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "followers")]
    public long?  Followers{ get; set; }

    /// <summary>
    /// profile path
    /// </summary>
    [DataMember(Name = "profileImagePath", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "profileImagePath")]
    public string?  ProfileImagePath{ get; set; }

    /// <summary>
    /// cover path
    /// </summary>
    [DataMember(Name = "coverImagePath", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "coverImagePath")]
    public string?  CoverImagePath{ get; set; }

    /// <summary>
    /// author
    /// </summary>
    [DataMember(Name = "author", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "author")]
    public string?  Author{ get; set; }

    /// <summary>
    /// tokens
    /// </summary>
    [DataMember(Name = "tokens", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "tokens")]
    public string?  Tokens{ get; set; }

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
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
