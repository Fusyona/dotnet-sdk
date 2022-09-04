using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Fusyona.Dotnet.Sdk.Models;

namespace Fusyona.Dotnet.Sdk.Dtos;

public class CollectionPostDto
{
    /// <summary>
    /// The blockchain network of the Collection Post Dto
    /// </summary>
    [DataMember(Name = "blockchainNetwork", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "blockchainNetwork")]
    public string? BlockchainNetwork { get; set; }

    /// <summary>
    /// The name of the Collection Post Dto
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "name")]
    public string? Name { get; set; }

    /// <summary>
    /// The description of the Collection Post Dto
    /// </summary>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "description")]
    public string? Description { get; set; }

    /// <summary>
    /// The royalties of the Collection Post Dto
    /// </summary>
    [DataMember(Name = "royalties", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "royalties")]
    public decimal? Royalties { get; set; }

    /// <summary>
    /// The external link of the Collection Post Dto
    /// </summary>
    [DataMember(Name = "externalLink", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "externalLink")]
    public string? ExternalLink { get; set; }

    /// <summary>
    /// The cover image of the Collection Post Dto
    /// </summary>
    [DataMember(Name = "coverImage", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "coverImage")]
    public CollectionImage? CoverImage { get; set; }

    /// <summary>
    /// The logo image of the Collection Post Dto
    /// </summary>
    [DataMember(Name = "logoImage", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "logoImage")]
    public CollectionImage? LogoImage { get; set; }

    /// <summary>
    /// The featured image of the Collection Post Dto
    /// </summary>
    [DataMember(Name = "featuredImage", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "featuredImage")]
    public CollectionImage? FeaturedImage { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class collectionPostDto{");
        sb.Append("  Name ").Append(Name).Append("\n");
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