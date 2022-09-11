using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Fusyona.Nft.Models;

[DataContract]
public class TokenAttachment
{
    /// <summary>
	/// The id of the NFT attachment
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	[JsonProperty(PropertyName = "id")]
	public string? Id { get; set; }

    /// <summary>
	/// The file path of the NFT attachment
	/// </summary>
	[DataMember(Name = "filePath", EmitDefaultValue = false)]
	[JsonProperty(PropertyName = "filePath")]
	public string? FilePath { get; set; }

    /// <summary>
	/// The content type of the NFT attachment
	/// </summary>
	[DataMember(Name = "contentType", EmitDefaultValue = false)]
	[JsonProperty(PropertyName = "contentType")]
	public string? ContentType { get; set; }

    /// <summary>
	/// Get the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class nftAttachment {");
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