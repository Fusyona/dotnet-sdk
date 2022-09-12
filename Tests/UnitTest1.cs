
using System;
using Xunit;
using Fusyona.Nft;

namespace Tests;

public class UnitTest1
{
    string bearerToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJleHAiOjE2NjI5MTk2MTIsIm5iZiI6MTY2MjkxNjAxMiwidmVyIjoiMS4wIiwiaXNzIjoiaHR0cHM6Ly9hY2NvdW50cy5mdXN5b25hLmNvbS9mOTE0MTYyZC1jMGMzLTQ5MGItOTNkNS0xZDhjZmUxYTQ3OTkvdjIuMC8iLCJzdWIiOiJmYWVmMjIzZi0zZjM4LTRkYTAtYTc3Zi1iODZjOTA2MjUyZTAiLCJhdWQiOiI4N2FiZWQ5NC0yNWY0LTRmMmMtOWNmMi1kMjk4ODMyODlkM2EiLCJub25jZSI6IjNmZjk1OTI1LTE2OGEtMmUwMS1hODg1LTg3ZDk1MmUyZDc0NSIsImlhdCI6MTY2MjkxNjAxMiwiYXV0aF90aW1lIjoxNjYyOTE2MDEyLCJvaWQiOiJmYWVmMjIzZi0zZjM4LTRkYTAtYTc3Zi1iODZjOTA2MjUyZTAiLCJnaXZlbl9uYW1lIjoiTGVhbmRybyIsImZhbWlseV9uYW1lIjoibGxscmRneiIsImVtYWlscyI6WyJsZWFuZHJvX19yb2RyaWd1ZXpAb3V0bG9vay5jb20iXSwidGZwIjoiQjJDXzFfU2lnblVwSW4ifQ.O5Z6UQP7JEaPRamAPv03bahE2CUI1ht7_a2X-Rv_XYFVUTYo3daKdfNkBHmoI3ygLDhcJ6jhXEZLaWQL5Dwlwh6m8PP1KK1ZUJNYIgOj6WogXAeP6y4F1WyS35f9nSAZ2o77VBCC5uv_hG77MQD4MjKcREm9BGKwmy0KbQuXL2sOPC8DDq-5-kpOclwFQyrO7OizTKvo8BSlTLtHH5yZ53uPyN3S2rmAR7Y2ia-TzipXRuB6u5-ShddHA7YLNusGvNsWS59CCOYdQWpzW5zUkGi72bvo9Nr0__KS4__g-Y9CsrMoNfSvd73JYyqmWRDjRB8SHt-LiXFLJnqL4Qh4LA";
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

}
