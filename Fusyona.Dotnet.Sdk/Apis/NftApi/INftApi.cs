using Fusyona.Dotnet.Sdk.Models;

namespace Fusyona.Dotnet.Sdk.Apis;

public interface INftApi
{
    Task<string> MintNft(string bearerToken, string collectionId, string title, string description, string category, int supply, string tags, string attachmentPath, string attributes, string privacy, string externalLink, string codes);
    Task<Nft> GetNft(string bearerToken, string collectionId, string nftId);
    Task<IEnumerable<Nft>> GetNfts(string bearerToken, string collectionId);
    Task<IEnumerable<Nft>> GetNftsWithPagination(string bearerToken, string collectionId, int page);
    Task<IEnumerable<Nft>> GetAllTokensListWithPagination(string bearerToken, int page);
    Task<string> CreateCollection(string bearerToken, string blockchainNetwork, string name, string description, decimal royalties, string externalLink, string coverImagePath, string featuredImagePath, string logoImagePath);
    Task<Collection> GetCollection(string bearerToken, string collectionId);
    Task<IEnumerable<Collection>> GetCollections(string bearerToken);
    Task<IEnumerable<Collection>> GetCollectionsWithPagination(string bearerToken, int page);
}