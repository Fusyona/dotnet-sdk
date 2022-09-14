
using System;
using System.Net;
using Xunit;
using Fusyona.Nft;

namespace Tests;

public class NftTests
{
    string bearerToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJpc3MiOiJodHRwczovL2FjY291bnRzLmZ1c3lvbmEuY29tL2Y5MTQxNjJkLWMwYzMtNDkwYi05M2Q1LTFkOGNmZTFhNDc5OS92Mi4wLyIsImV4cCI6MTY2MzE4OTg3NywibmJmIjoxNjYzMTg2Mjc3LCJhdWQiOiI4N2FiZWQ5NC0yNWY0LTRmMmMtOWNmMi1kMjk4ODMyODlkM2EiLCJvaWQiOiIxNThkOTE3Mi1kMWM1LTQwN2ItODU4ZS1lM2Q1MzhmNjFjZjciLCJzdWIiOiIxNThkOTE3Mi1kMWM1LTQwN2ItODU4ZS1lM2Q1MzhmNjFjZjciLCJnaXZlbl9uYW1lIjoiUm9sYW5kbyIsImZhbWlseV9uYW1lIjoiU2FuY2hleiBSYW1vcyIsImVtYWlscyI6WyJyb2xzYW5jaGV6QHlhbmRleC5jb20iXSwidGZwIjoiQjJDXzFfU2lnblVwSW4iLCJub25jZSI6ImRiM2MyOTBiLWZjODAtNDFhZS1hYzkzLTc5ZWQ3Yjk0ZDZhMyIsInNjcCI6IldyaXRlVXNlclByb2ZpbGVBUEkgUmVhZFVzZXJQcm9maWxlQVBJIiwiYXpwIjoiZWI5MzY3MDctNTkzZS00OWQzLTgwMjgtMTA3NjBkNWI5YjI5IiwidmVyIjoiMS4wIiwiaWF0IjoxNjYzMTg2Mjc3fQ.pnz3bmjbdjfkNDEsyPO8g5PiQlm_Ix2P2RVYiDNJa0Y9e-qdD9okvNh5KMOB-1vr0Nov8SIXZBcwgRlgBpXMtL8iYYol_UAZhY85_oANoZIDcsOi2Dmw5zaWuBacj9dtB7LWUP7tQZog4SmRrkN9P1MShALpRa1QVpw8k0rFfnAcm3gB9QtVkY_sXqeUPUoGMeRbun_FWif3w-15rc3pwpJz2C0kbhrHd0RjnO2RW5a7Mc-sw4Igm3d5VWmTo2G7ekTYZv7oeJVew3MgO7UN5Vs7jGiaZAK7AVZZLT-GvyYuoaiMCO3eOYr-dCJCmVf212-xiWK3iBDTCYwb0ttTQQ";
    string subcriptionKey = "710e277524cc426baf6c8ef1eb930af5;product=starter";

    [Fact]
    public async void Test1()
    {   
        string collectionId = "754ac980-38a9-4379-8774-51568260578d";

        var collection = await Nft.GetSingleCollection(bearerToken, subcriptionKey, collectionId);

        Console.WriteLine(collection);
    }

    [Fact]
    public async void Test2()
    {
        var collections = await Nft.GetCollectionsListWithPagination(bearerToken, subcriptionKey, 1);

        foreach (var collection in collections)
            Console.WriteLine(collection);
    }

    [Fact]
    public async void Test3()
    {
        var collections = await Nft.GetCollectionsList(bearerToken, subcriptionKey);

        foreach (var collection in collections)
            Console.WriteLine(collection);
    }

    [Fact]
    public async void Test4()
    {
        string collectionId = "0685f215-eeb7-43e5-9627-de0cb8ee37de";
        string tokenId = "e120edea-8c67-40ff-a8e4-1465f1be7470";

        var collection = await Nft.GetSingleToken(
            bearerToken, subcriptionKey, collectionId, tokenId
        );

        Console.WriteLine(collection);
    }

    [Fact]
    public async void Test5()
    {
        string collectionId = "0685f215-eeb7-43e5-9627-de0cb8ee37de";
        string tokenId = "e120edea-8c67-40ff-a8e4-1465f1be7470";

        string blockchainNetwork = "Polygon";
        string name = "CollectDotnet";
        string description = "Dotnet";
        decimal royalties = 5;
        string externalLink = "www.fusyona.com";
        string path = "https://media.istockphoto.com/photos/server-configuration-command-lines-on-a-monitor-picture-id619051530";

        //Download sample image
        using (WebClient webClient = new WebClient())
        {
            webClient.DownloadFile(path, "image.png");
        }

        path = "image.png";

        var response = await Nft.CreateCollection(
            bearerToken, subcriptionKey, blockchainNetwork,
            name, description, royalties, externalLink, path,
            path, path
        );

        Console.WriteLine(response);
    }

    [Fact]
    public async void Test6()
    {
        var nfts = await Nft.GetAllTokensListWithPagination(bearerToken, subcriptionKey, 1);

        foreach (var nft in nfts)
            Console.WriteLine(nft);
    }

    [Fact]
    public async void Test7()
    {
        string collectionId = "2b28d238-746f-444d-93a0-f4077774f5a3";
        var nfts = await Nft.GetTokensList(bearerToken, subcriptionKey, collectionId);

        foreach (var nft in nfts)
            Console.WriteLine(nft);
    }

    [Fact]
    public async void Test8()
    {
        string collectionId = "754ac980-38a9-4379-8774-51568260578d";
        var nfts = await Nft.GetTokensListWithPagination(bearerToken, subcriptionKey, collectionId, 1);

        foreach (var nft in nfts)
            Console.WriteLine(nft);
    }

    [Fact]
    public async void Test9()
    {
        string title = "TokenSports";
        string description = "DescriptTokenSport";
        string category = "sports";
        int supply = 5;
        string tags = "tags";
        string path = "https://media.istockphoto.com/photos/server-configuration-command-lines-on-a-monitor-picture-id619051530";
        string attributes = "attributes";
        string privacy = "public";
        string externalLink = "www.fusyona.net";
        string codes = "codes";
        string collectionId = "86beb65c-e4fa-41ee-adcd-e81720482618";

        //Download sample image
        using (WebClient webClient = new WebClient())
        {
            webClient.DownloadFile(path, "image.png");
        }

        path = "image.png";

        var response = await Nft.MintToken(
        bearerToken, subcriptionKey, collectionId, title, description, category,
        supply, tags, path, attributes, privacy,
        externalLink, codes
        );

        Console.WriteLine(response);
    }

}
