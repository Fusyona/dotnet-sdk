using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Fusyona.Dotnet.Sdk.Models;

[DataContract]
public class Collection
{
    /// <summary>
	/// The id of the collection
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	[JsonProperty(PropertyName = "id")]
	public string? Id { get; set; }

    /// <summary>
	/// The author id of the collection
	/// </summary>
	[DataMember(Name = "authorId", EmitDefaultValue = false)]
	[JsonProperty(PropertyName = "authorId")]
	public string? AuthorId { get; set; }

    /// <summary>
    /// The type of the collection
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "type")]
    public string? Type { get; set; }

    /// <summary>
    /// The creation date of the collection
    /// </summary>
    [DataMember(Name = "creationDate", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "creationDate")]
    public DateTimeOffset? CreationDate { get; set; }

    /// <summary>
    /// The category of the collection
    /// </summary>
    [DataMember(Name = "category", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "category")]
    public string? Category { get; set; }

    /// <summary>
    /// The author of the collection
    /// </summary>
    [DataMember(Name = "author", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "author")]
    public string? Author { get; set; }

    /// <summary>
    /// The collection id of the collection
    /// </summary>
    [DataMember(Name = "collectionId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "collectionId")]
    public string? CollectionId { get; set; }

    /// <summary>
    /// The tags of the collection
    /// </summary>
    [DataMember(Name = "tags", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "tags")]
    public string? Tags { get; set; }

    /// <summary>
    /// The privacy of the collection
    /// </summary>
    [DataMember(Name = "privacy", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "privacy")]
    public string? Privacy { get; set; }

    /// <summary>
    /// The owner id of the collection
    /// </summary>
    [DataMember(Name = "ownerId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "ownerId")]
    public string? OwnerId { get; set; }

    /// <summary>
    /// The cover image of the collection
    /// </summary>
    [DataMember(Name = "coverImage", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "coverImage")]
    public CollectionImage? CoverImage { get; set; }

    /// <summary>
    /// The logo image of the collection
    /// </summary>
    [DataMember(Name = "logoImage", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "logoImage")]
    public CollectionImage? LogoImage { get; set; }

    /// <summary>
    /// The featured image of the collection
    /// </summary>
    [DataMember(Name = "featuredImage", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "featuredImage")]
    public CollectionImage? FeaturedImage { get; set; }

    /// <summary>
    /// The blockchain network of the collection
    /// </summary>
    [DataMember(Name = "blockchainNetwork", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "blockchainNetwork")]
    public string? BlockchainNetwork { get; set; }

    /// <summary>
    /// The contract address of the collection
    /// </summary>
    [DataMember(Name = "contractAddress", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "contractAddress")]
    public string? ContractAddress { get; set; }

    /// <summary>
    /// The external link of the collection
    /// </summary>
    [DataMember(Name = "externalLink", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "externalLink")]
    public string? ExternalLink { get; set; }

    /// <summary>
    /// The name of the collection
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "name")]
    public string? Name { get; set; }

    /// <summary>
    /// The description of the collection
    /// </summary>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "description")]
    public string? Description { get; set; }

    /// <summary>
    /// The royalties of the collection
    /// </summary>
    [DataMember(Name = "royalties", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "royalties")]
    public decimal? Royalties { get; set; }

    /// <summary>
    /// The number of tokens of the collection
    /// </summary>
    [DataMember(Name = "numberOfTokens", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "numberOfTokens")]
    public int? NumberOfTokens { get; set; }

    /// <summary>
    /// The status of the collection
    /// </summary>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "status")]
    public string? Status { get; set; }

    /// <summary>
    /// The transaction hash of the collection
    /// </summary>
    [DataMember(Name = "transactionHash", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "transactionHash")]
    public string? TransactionHash { get; set; }

    /// <summary>
	/// Get the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class collection {");
		sb.Append(" Id ").Append(Id).Append("\n");
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
        

