using Fusyona.Dotnet.Sdk.Models;
using Fusyona.Dotnet.Sdk.Dtos;

namespace Fusyona.Dotnet.Sdk.Apis;

public interface INftApi
{
    Task<NftPostDto> MintNft(string bearerToken, NftPostDto nftDto);
    Task<Nft> GetNft(string nftId);
    Task<IEnumerable<Nft>> GetNfts();
    Task<IEnumerable<Nft>> GetNftsWithPagination(int page);
    Task<CollectionPostDto> CreateCollection(string bearerToken, CollectionPostDto collectionDto);
    Task<Collection> GetCollection(string collectionId);
    Task<IEnumerable<Collection>> GetCollections();
    Task<IEnumerable<Collection>> GetCollectionsWithPagination(int page);
}