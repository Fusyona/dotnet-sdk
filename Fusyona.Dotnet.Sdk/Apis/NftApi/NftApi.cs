using Fusyona.Dotnet.Sdk.Dtos;
using Fusyona.Dotnet.Sdk.Models;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Net.Http.Headers;

namespace Fusyona.Dotnet.Sdk.Apis;

public class NftApi : INftApi
{
    private readonly string baseUrl;
    private readonly HttpClient client;

    public NftApi()
    {
        baseUrl = "https://nft-marketplace-api.azurewebsites.net/api/";
        client = new HttpClient { BaseAddress = new Uri(baseUrl) };
    }

    public async Task<CollectionPostDto> CreateCollection(string bearerToken, CollectionPostDto collectionDto)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("collections", collectionDto);
        response.EnsureSuccessStatusCode();

        // return the created resource.
        return collectionDto;
    }

    public async Task<Collection> GetCollection(string bearerToken, string collectionId)
    {
        Collection? collection = new Collection();
        var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + $"collections/{collectionId}");
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

        HttpResponseMessage response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
            var apiString = await response.Content.ReadAsStringAsync();
            collection = JsonConvert.DeserializeObject<Collection>(apiString);
        }

        if (collection is null)
            return new Collection();

        return collection;
    }

    public async Task<IEnumerable<Collection>> GetCollections(string bearerToken)
    {
        List<Collection>? collections = new List<Collection>();
        var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + "collections");
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

        HttpResponseMessage response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
            var apiString = await response.Content.ReadAsStringAsync();
            collections = JsonConvert.DeserializeObject<List<Collection>>(apiString);
        }

        if (collections is null)
            return new List<Collection>();

        return collections;
    }

    public async Task<IEnumerable<Collection>> GetCollectionsWithPagination(string bearerToken, int page)
    {
        List<Collection>? collections = new List<Collection>();
        var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + $"collections/pages/{page}");
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

        HttpResponseMessage response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
            var apiString = await response.Content.ReadAsStringAsync();
            collections = JsonConvert.DeserializeObject<List<Collection>>(apiString);
        }

        if (collections is null)
            return new List<Collection>();

        return collections;
    }

    public async Task<IEnumerable<Nft>> GetAllTokensListWithPagination(string bearerToken, int page)
    {
        List<Nft>? nfts = new List<Nft>();
        var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + $"tokens/pages/{page}");
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

        HttpResponseMessage response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
            var apiString = await response.Content.ReadAsStringAsync();
            nfts = JsonConvert.DeserializeObject<List<Nft>>(apiString);
        }

        if (nfts is null)
            return new List<Nft>();

        return nfts;
    }

    public async Task<Nft> GetNft(string bearerToken, string collectionId, string nftId)
    {
        Nft? nft = new Nft();
        var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + $"collections/{collectionId}/tokens/{nftId}");
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

        HttpResponseMessage response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
            var apiString = await response.Content.ReadAsStringAsync();
            nft = JsonConvert.DeserializeObject<Nft>(apiString);
        }

        if (nft is null)
            return new Nft();

        return nft;
    }

    public async Task<IEnumerable<Nft>> GetNfts(string bearerToken, string collectionId)
    {
        List<Nft>? nfts = new List<Nft>();
        var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + $"collections/{collectionId}/tokens");
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

        HttpResponseMessage response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
            var apiString = await response.Content.ReadAsStringAsync();
            nfts = JsonConvert.DeserializeObject<List<Nft>>(apiString);
        }

        if (nfts is null)
            return new List<Nft>();

        return nfts;
    }

    public async Task<IEnumerable<Nft>> GetNftsWithPagination(string bearerToken, string collectionId, int page)
    {
        List<Nft>? nfts = new List<Nft>();
        var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + $"collections/{collectionId}/tokens/pages/{page}");
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

        HttpResponseMessage response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
            var apiString = await response.Content.ReadAsStringAsync();
            nfts = JsonConvert.DeserializeObject<List<Nft>>(apiString);
        }

        if (nfts is null)
            return new List<Nft>();

        return nfts;
    }

    public async Task<NftPostDto> MintNft(string bearerToken, string collectionId, NftPostDto nftDto)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("collections", nftDto);
        response.EnsureSuccessStatusCode();

        // return the created resource.
        return nftDto;
    }
}