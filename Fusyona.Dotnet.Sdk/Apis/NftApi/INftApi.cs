using Fusyona.Dotnet.Sdk.Models;
using Fusyona.Dotnet.Sdk.Dtos;

namespace Fusyona.Dotnet.Sdk.Apis;

public interface INftApi
{
    Task<NftPostDto> MintNft(string bearerToken, NftPostDto nftDto);
    Task<Nft> GetNft(string bearerToken, string collectionId, string nftId);
    Task<IEnumerable<Nft>> GetNfts(string bearerToken, string collectionId);
    Task<IEnumerable<Nft>> GetNftsWithPagination(string bearerToken, string collectionId, int page);
    Task<IEnumerable<Nft>> GetGiftsWithPagination(string bearerToken, string collectionId, int page);
    Task<CollectionPostDto> CreateCollection(string bearerToken, CollectionPostDto collectionDto);
    Task<Collection> GetCollection(string bearerToken, string collectionId);
    Task<IEnumerable<Collection>> GetCollections(string bearerToken);
    Task<IEnumerable<Collection>> GetCollectionsWithPagination(string bearerToken, int page);
}