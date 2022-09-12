using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Fusyona.Nft.Models;

[DataContract]
public class Token
{
    /// <summary>
    /// The id of the NFT
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "id")]
    public string? Id { get; set; }

    /// <summary>
    /// The token id of the NFT
    /// </summary>
    [DataMember(Name = "tokenId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "tokenId")]
    public string? TokenId { get; set; }

    /// <summary>
    /// The user id of the NFT owner
    /// </summary>
    [DataMember(Name = "userId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// The name of the NFT
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "name")]
    public string? Name { get; set; }

    /// <summary>
    /// The description of the NFT
    /// </summary>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "description")]
    public string? Description { get; set; }

    /// <summary>
    /// The number of copies of the NFT
    /// </summary>
    [DataMember(Name = "numberOfCopies", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "numberOfCopies")]
    public int? NumberOfCopies { get; set; }

    /// <summary>
    /// The json url of the NFT
    /// </summary>
    [DataMember(Name = "jsonUrl", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "jsonUrl")]
    public string? JsonUrl { get; set; }

    /// <summary>
    /// The attachment url of the NFT
    /// </summary>
    [DataMember(Name = "attachmentUrl", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "attachmentUrl")]
    public string? AttachmentUrl { get; set; }

    /// <summary>
    /// The blockchain network of the NFT
    /// </summary>
    [DataMember(Name = "blockchainNetwork", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "blockchainNetwork")]
    public string? BlockchainNetwork { get; set; }

    /// <summary>
    /// The contract address of the NFT
    /// </summary>
    [DataMember(Name = "contractAddress", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "contractAddress")]
    public string? ContractAddress { get; set; }

    /// <summary>
    /// The creation date of the NFT
    /// </summary>
    [DataMember(Name = "creationDate", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "creationDate")]
    public DateTimeOffset? CreationDate { get; set; }

    /// <summary>
    /// The author of the NFT
    /// </summary>
    [DataMember(Name = "author", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "author")]
    public string? Author { get; set; }

    /// <summary>
    /// The author id of the NFT
    /// </summary>
    [DataMember(Name = "authorId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "authorId")]
    public string? AuthorId { get; set; }

    /// <summary>
    /// The author email of the NFT
    /// </summary>
    [DataMember(Name = "authorEmail", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "authorEmail")]
    public string? AuthorEmail { get; set; }

    /// <summary>
    /// The type of the NFT
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "type")]
    public string? Type { get; set; }

    /// <summary>
    /// The status of the NFT
    /// </summary>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "status")]
    public string? Status { get; set; }

    /// <summary>
    /// The available gifts of the NFT
    /// </summary>
    [DataMember(Name = "availableGifts", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "availableGifts")]
    public int? AvailableGifts { get; set; }

    /// <summary>
    /// The total of gifts of the NFT
    /// </summary>
    [DataMember(Name = "totalOfGifts", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "totalOfGifts")]
    public int? TotalOfGifts { get; set; }

    /// <summary>
    /// The total of auctions of the NFT
    /// </summary>
    [DataMember(Name = "totalOfAuctions", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "totalOfAuctions")]
    public int? TotalOfAuctions { get; set; }

    /// <summary>
    /// The available auctions of the NFT
    /// </summary>
    [DataMember(Name = "availableAuctions", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "availableAuctions")]
    public int? AvailableAuctions { get; set; }

    /// <summary>
    /// The total of sells of the NFT
    /// </summary>
    [DataMember(Name = "totalOfSells", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "totalOfSells")]
    public int? TotalOfSells { get; set; }

    /// <summary>
    /// The available sells of the NFT
    /// </summary>
    [DataMember(Name = "availableSells", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "availableSells")]
    public int? AvailableSells { get; set; }

    /// <summary>
    /// The royalties of the NFT
    /// </summary>
    [DataMember(Name = "royalties", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "royalties")]
    public decimal? Royalties { get; set; }

    /// <summary>
    /// The transaction hash of the NFT
    /// </summary>
    [DataMember(Name = "transactionHash", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "transactionHash")]
    public string? TransactionHash { get; set; }

    /// <summary>
    /// The set url transaction hash of the NFT
    /// </summary>
    [DataMember(Name = "setUrlTransactionHash", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "setUrlTransactionHash")]
    public string? SetUrlTransactionHash { get; set; }

    /// <summary>
    /// The set royalties transaction hash of the NFT
    /// </summary>
    [DataMember(Name = "setRoyaltiesTransactionHash", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "setRoyaltiesTransactionHash")]
    public string? SetRoyaltiesTransactionHash { get; set; }

    /// <summary>
    /// The collection id of the NFT
    /// </summary>
    [DataMember(Name = "collectionId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "collectionId")]
    public string? CollectionId { get; set; }

    /// <summary>
    /// The currency id of the NFT
    /// </summary>
    [DataMember(Name = "currencyId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "currencyId")]
    public string? CurrencyId { get; set; }

    /// <summary>
    /// The attachment of the NFT
    /// </summary>
    [DataMember(Name = "attachment", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "attachment")]
    public TokenAttachment? Attachment { get; set; }

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
