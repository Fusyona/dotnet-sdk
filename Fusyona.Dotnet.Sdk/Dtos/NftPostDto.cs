using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Fusyona.Dotnet.Sdk.Models;

namespace Fusyona.Dotnet.Sdk.Dtos;

public class NftPostDto
{
    /// <summary>
    /// The title of the Nft Post Dto
    /// </summary>
    [DataMember(Name = "title", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "title")]
    public string? Title { get; set; }

    /// <summary>
    /// The description of the Nft Post Dto
    /// </summary>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "description")]
    public string? Description { get; set; }

    /// <summary>
    /// The category of the Nft Post Dto
    /// </summary>
    [DataMember(Name = "category", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "category")]
    public string? Category { get; set; }

    /// <summary>
    /// The supply of the Nft Post Dto
    /// </summary>
    [DataMember(Name = "supply", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "supply")]
    public int? Supply { get; set; }

    /// <summary>
    /// The collection id of the Nft Post Dto
    /// </summary>
    [DataMember(Name = "collectionId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "collectionId")]
    public string? CollectionId { get; set; }

    /// <summary>
    /// The tags of the Nft Post Dto
    /// </summary>
    [DataMember(Name = "tags", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "tags")]
    public string? Tags { get; set; }

    /// <summary>
    /// The attachment of the Nft Post Dto
    /// </summary>
    [DataMember(Name = "attachment", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "attachment")]
    public NftAttachment? attachment { get; set; }

    /// <summary>
    /// The attributes of the Nft Post Dto
    /// </summary>
    [DataMember(Name = "attributes", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "attributes")]
    public string? Attributes { get; set; } 

    /// <summary>
    /// The privacy of the Nft Post Dto
    /// </summary>
    [DataMember(Name = "privacy", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "privacy")]
    public string? Privacy { get; set; }

    /// <summary>
    /// The external link of the Nft Post Dto
    /// </summary>
    [DataMember(Name = "externalLink", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "externalLink")]
    public string? ExternalLink { get; set; }

    /// <summary>
    /// The codes of the Nft Post Dto
    /// </summary>
    [DataMember(Name = "codes", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "codes")]
    public string? Codes { get; set; }

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class nftPostDto{");
        sb.Append("  Title ").Append(Title).Append("\n");
        sb.Append("}");

        return sb.ToString();
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