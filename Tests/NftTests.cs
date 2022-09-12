
using System;
using System.Net;
using Xunit;
using Fusyona.Nft;

namespace Tests;

public class NftTests
{
    string bearerToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJpc3MiOiJodHRwczovL2FjY291bnRzLmZ1c3lvbmEuY29tL2Y5MTQxNjJkLWMwYzMtNDkwYi05M2Q1LTFkOGNmZTFhNDc5OS92Mi4wLyIsImV4cCI6MTY2MzAyOTQxOCwibmJmIjoxNjYzMDI1ODE4LCJhdWQiOiI4N2FiZWQ5NC0yNWY0LTRmMmMtOWNmMi1kMjk4ODMyODlkM2EiLCJvaWQiOiIxNThkOTE3Mi1kMWM1LTQwN2ItODU4ZS1lM2Q1MzhmNjFjZjciLCJzdWIiOiIxNThkOTE3Mi1kMWM1LTQwN2ItODU4ZS1lM2Q1MzhmNjFjZjciLCJnaXZlbl9uYW1lIjoiUm9sYW5kbyIsImZhbWlseV9uYW1lIjoiU2FuY2hleiBSYW1vcyIsImVtYWlscyI6WyJyb2xzYW5jaGV6QHlhbmRleC5jb20iXSwidGZwIjoiQjJDXzFfU2lnblVwSW4iLCJub25jZSI6ImIxYjU0NjliLWVmZWItNDBhYi04ODg2LTIyNGU5MTk5MTgxYSIsInNjcCI6IldyaXRlVXNlclByb2ZpbGVBUEkgUmVhZFVzZXJQcm9maWxlQVBJIiwiYXpwIjoiZWI5MzY3MDctNTkzZS00OWQzLTgwMjgtMTA3NjBkNWI5YjI5IiwidmVyIjoiMS4wIiwiaWF0IjoxNjYzMDI1ODE4fQ.N9Kg8rsOz0eSfWp77h6hdfQ-J_4tREyAOFpB8V4ZM6SoelSQOz6B8lcQ2cQ3XbjTe05OaTp35KWHQYaMxK9UmlMsvvdKeqZZDSwwq1EOIrcENPUuAqzfYoxIqD7ZVVxmVhmc51qlfPRez0-GTooa6yoIRndkBqe9ODtgYZnSQ1pOf2Yl-i9uYoh-TmkcL0UlEJSGxD8Xyy5SRS2Iu5O5QL03_mxCHXG2G4yuRkl93bWVNZEEGAeucjcSajOX8rd0m-KChpjbXP8rlqAEPjW_5i--9NP--2q7Q9QHRBcrlDcVZwDKvUxYnDiCsDeB2TQva_OQ_3oluM4QjYxUCocVew";
    string subcriptionKey = "710e277524cc426baf6c8ef1eb930af5;product=starter";

    // [Fact]
    // public async void Test1()
    // {   
    //     string collectionId = "754ac980-38a9-4379-8774-51568260578d";

    //     var collection = await Nft.GetSingleCollection(bearerToken, subcriptionKey, collectionId);

    //     Console.WriteLine(collection);
    // }

    // [Fact]
    // public async void Test2()
    // {
    //     var collections = await Nft.GetCollectionsListWithPagination(bearerToken, subcriptionKey, 1);

    //     foreach (var collection in collections)
    //         Console.WriteLine(collection);
    // }

    // [Fact]
    // public async void Test3()
    // {
    //     var collections = await Nft.GetCollectionsList(bearerToken, subcriptionKey);

    //     foreach (var collection in collections)
    //         Console.WriteLine(collection);
    // }

    // [Fact]
    // public async void Test4()
    // {
    //     string collectionId = "0685f215-eeb7-43e5-9627-de0cb8ee37de";
    //     string tokenId = "e120edea-8c67-40ff-a8e4-1465f1be7470";

    //     var collection = await Nft.GetSingleToken(
    //         bearerToken, subcriptionKey, collectionId, tokenId
    //     );

    //     Console.WriteLine(collection);
    // }

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
}
