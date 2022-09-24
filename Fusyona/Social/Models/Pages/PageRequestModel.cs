using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Fusyona.Social.Models;

[DataContract]
public class PageRequestModel
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
    /// author id
    /// </summary>
    [DataMember(Name = "authorId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "authorId")]
    public string?  AuthorId{ get; set; }

    /// <summary>
    /// tokens
    /// </summary>
    [DataMember(Name = "tokens", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "tokens")]
    public string?  Tokens{ get; set; }

    /// <summary>
    /// address
    /// </summary>
    [DataMember(Name = "address", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "address")]
    public string?  Address{ get; set; }

    /// <summary>
    /// web
    /// </summary>
    [DataMember(Name = "web", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "web")]
    public string?  Web{ get; set; }

    /// <summary>
    /// phone
    /// </summary>
    [DataMember(Name = "phone", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "phone")]
    public string?  Phone{ get; set; }

    /// <summary>
    /// email
    /// </summary>
    [DataMember(Name = "email", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "email")]
    public string?  Email{ get; set; }

    /// <summary>
    /// whatsapp
    /// </summary>
    [DataMember(Name = "whatsapp", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "whatsapp")]
    public string?  Whatsapp{ get; set; }

    /// <summary>
    /// fb
    /// </summary>
    [DataMember(Name = "facebookURL", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "facebookURL")]
    public string?  FacebookURL{ get; set; }

    /// <summary>
    /// ig
    /// </summary>
    [DataMember(Name = "instagramURL", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "instagramURL")]
    public string?  InstagramURL{ get; set; }

    /// <summary>
    /// linkedin
    /// </summary>
    [DataMember(Name = "linkedinURL", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "linkedinURL")]
    public string?  LinkedinURL{ get; set; }

    /// <summary>
    /// subs
    /// </summary>
    [DataMember(Name = "subscription", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "subscription")]
    public string?  Subscription{ get; set; }

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
