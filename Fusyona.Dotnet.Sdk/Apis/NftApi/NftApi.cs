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
        using (var multipartFormContent = new MultipartFormDataContent())
        {
            //Add first fields
            multipartFormContent.Add(new StringContent(blockchainNetwork), name: "blockchainNetwork");
            multipartFormContent.Add(new StringContent(name), name: "name");
            multipartFormContent.Add(new StringContent(description), name: "description");
            multipartFormContent.Add(new StringContent(royalties.ToString()), name: "royalties");
            multipartFormContent.Add(new StringContent(externalLink), name: "externalLink");

            //Add the images
            var fileStreamContent1 = new StreamContent(File.OpenRead(coverImagePath));
            fileStreamContent1.Headers.ContentType = new MediaTypeHeaderValue("image/png");
            multipartFormContent.Add(fileStreamContent1, name: "coverImage", fileName: "coverImage");

            var fileStreamContent2 = new StreamContent(File.OpenRead(featuredImagePath));
            fileStreamContent2.Headers.ContentType = new MediaTypeHeaderValue("image/png");
            multipartFormContent.Add(fileStreamContent2, name: "featuredImage", fileName: "coverImage");

            var fileStreamContent3 = new StreamContent(File.OpenRead(logoImagePath));
            fileStreamContent3.Headers.ContentType = new MediaTypeHeaderValue("image/png");
            multipartFormContent.Add(fileStreamContent3, name: "logoImage", fileName: "coverImage");

            //Add bearer token to a default client header
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

            //Send it
            var response = await client.PostAsync(baseUrl + "collections", multipartFormContent);
            response.EnsureSuccessStatusCode();
            
            //Getting the approvedLink
            string apiString = await response.Content.ReadAsStringAsync();
            var jo = JObject.Parse(apiString);
            var approvedLink = jo["payment"]["value"]["approvedLink"].ToString();

            //Approve the collection creation
            var requestApproveLink = new HttpRequestMessage(HttpMethod.Post, approvedLink);
            requestApproveLink.Headers.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
            var responseApproveLink = await client.SendAsync(requestApproveLink, HttpCompletionOption.ResponseHeadersRead);

            return responseApproveLink.StatusCode.ToString();
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
        using (var multipartFormContent = new MultipartFormDataContent())
        {
            //Add first fields
            multipartFormContent.Add(new StringContent(title), name: "title");
            multipartFormContent.Add(new StringContent(description), name: "description");
            multipartFormContent.Add(new StringContent(category), name: "category");
            multipartFormContent.Add(new StringContent(supply.ToString()), name: "supply");
            multipartFormContent.Add(new StringContent(tags), name: "tags");
            multipartFormContent.Add(new StringContent(attributes), name: "attributes");
            multipartFormContent.Add(new StringContent(privacy), name: "privacy");
            multipartFormContent.Add(new StringContent(externalLink), name: "externalLink");
            multipartFormContent.Add(new StringContent(codes), name: "codes");

            //Add the attachment
            var fileStreamContent1 = new StreamContent(File.OpenRead(attachmentPath));
            fileStreamContent1.Headers.ContentType = new MediaTypeHeaderValue("image/png");
            multipartFormContent.Add(fileStreamContent1, name: "attachment", fileName: "attachment");

            //Add bearer token to a default client header
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

            //Send it
            var response = await client.PostAsync(baseUrl + "collections", multipartFormContent);
            response.EnsureSuccessStatusCode();
            
            //Getting the approvedLink
            string apiString = await response.Content.ReadAsStringAsync();
            var jo = JObject.Parse(apiString);
            var approvedLink = jo["payment"]["value"]["approvedLink"].ToString();

            //Approve the collection creation
            var requestApproveLink = new HttpRequestMessage(HttpMethod.Post, approvedLink);
            requestApproveLink.Headers.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
            var responseApproveLink = await client.SendAsync(requestApproveLink, HttpCompletionOption.ResponseHeadersRead);

            return responseApproveLink.StatusCode.ToString();
        }
    }
}