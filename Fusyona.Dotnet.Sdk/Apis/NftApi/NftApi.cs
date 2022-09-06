using Fusyona.Dotnet.Sdk.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

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

    public async Task<string> CreateCollection(string bearerToken, string blockchainNetwork, string name, string description, decimal royalties, string externalLink, string coverImagePath, string featuredImagePath, string logoImagePath)
    {
        var filePath = @"C:\house.png";

        using (var multipartFormContent = new MultipartFormDataContent())
        {
            //Add other fields
            multipartFormContent.Add(new StringContent("123"), name: "UserId");
            multipartFormContent.Add(new StringContent("Home insurance"), name: "Title");

            //Add the file
            var fileStreamContent = new StreamContent(File.OpenRead(filePath));
            fileStreamContent.Headers.ContentType = new MediaTypeHeaderValue("image/png");
            multipartFormContent.Add(fileStreamContent, name: "file", fileName: "house.png");

            //Send it
            var response = await client.PostAsync("https://localhost:12345/files/", multipartFormContent);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
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
            var jo = JObject.Parse(apiString);
            var data = jo["data"].ToString();
            collections = JsonConvert.DeserializeObject<List<Collection>>(data);
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
            var jo = JObject.Parse(apiString);
            var data = jo["data"].ToString();
            nfts = JsonConvert.DeserializeObject<List<Nft>>(data);
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
            var jo = JObject.Parse(apiString);
            var data = jo["token"].ToString();
            nft = JsonConvert.DeserializeObject<Nft>(data);
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
            var jo = JObject.Parse(apiString);
            var data = jo["data"].ToString();
            nfts = JsonConvert.DeserializeObject<List<Nft>>(data);
        }

        if (nfts is null)
            return new List<Nft>();

        return nfts;
    }

    public async Task<string> MintNft(string bearerToken, string collectionId, string title, string description, string category, int supply, string tags, string attachmentPath, string attributes, string privacy, string externalLink, string codes)
    {
        var filePath = @"C:\house.png";

        using (var multipartFormContent = new MultipartFormDataContent())
        {
            //Add other fields
            multipartFormContent.Add(new StringContent("123"), name: "UserId");
            multipartFormContent.Add(new StringContent("Home insurance"), name: "Title");

            //Add the file
            var fileStreamContent = new StreamContent(File.OpenRead(filePath));
            fileStreamContent.Headers.ContentType = new MediaTypeHeaderValue("image/png");
            multipartFormContent.Add(fileStreamContent, name: "file", fileName: "house.png");

            //Send it
            var response = await client.PostAsync("https://localhost:12345/files/", multipartFormContent);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}