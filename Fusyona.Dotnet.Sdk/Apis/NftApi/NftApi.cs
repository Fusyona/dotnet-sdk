using Fusyona.Dotnet.Sdk.Dtos;
using Fusyona.Dotnet.Sdk.Models;

namespace Fusyona.Dotnet.Sdk.Apis;

public class NftApi : INftApi
{
    private readonly HttpClient client;
    private readonly string baseUrl;
    
    public NftApi()
    {
        client = new HttpClient();
        baseUrl = "https://nft-marketplace-api.azurewebsites.net/api/";
    }

    public Task<CollectionPostDto> CreateCollection(string bearerToken, CollectionPostDto collectionDto)
    {
        throw new NotImplementedException();
    }

    public Task<Collection> GetCollection(string collectionId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Collection>> GetCollections()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Collection>> GetCollectionsWithPagination(int page)
    {
        throw new NotImplementedException();
    }

    public Task<Nft> GetNft(string nftId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Nft>> GetNfts()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Nft>> GetNftsWithPagination(int page)
    {
        throw new NotImplementedException();
    }

    public Task<NftPostDto> MintNft(string bearerToken, NftPostDto nftDto)
    {
        throw new NotImplementedException();
    }
}