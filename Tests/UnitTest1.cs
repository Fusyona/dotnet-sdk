
using System;
using Xunit;
using Fusyona.Nft;

namespace Tests;

public class UnitTest1
{
    string bearerToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJleHAiOjE2NjI5MTUzNTYsIm5iZiI6MTY2MjkxMTc1NiwidmVyIjoiMS4wIiwiaXNzIjoiaHR0cHM6Ly9hY2NvdW50cy5mdXN5b25hLmNvbS9mOTE0MTYyZC1jMGMzLTQ5MGItOTNkNS0xZDhjZmUxYTQ3OTkvdjIuMC8iLCJzdWIiOiJmYWVmMjIzZi0zZjM4LTRkYTAtYTc3Zi1iODZjOTA2MjUyZTAiLCJhdWQiOiI4N2FiZWQ5NC0yNWY0LTRmMmMtOWNmMi1kMjk4ODMyODlkM2EiLCJub25jZSI6ImI0NDY0MGNmLTNlNTEtZDBhYi00N2M3LWZmYTU5YjE3YWIxMCIsImlhdCI6MTY2MjkxMTc1NiwiYXV0aF90aW1lIjoxNjYyOTExNzU2LCJvaWQiOiJmYWVmMjIzZi0zZjM4LTRkYTAtYTc3Zi1iODZjOTA2MjUyZTAiLCJnaXZlbl9uYW1lIjoiTGVhbmRybyIsImZhbWlseV9uYW1lIjoibGxscmRneiIsImVtYWlscyI6WyJsZWFuZHJvX19yb2RyaWd1ZXpAb3V0bG9vay5jb20iXSwidGZwIjoiQjJDXzFfU2lnblVwSW4ifQ.AQJ3IC7jzX715nicnL_gemHVH7ZM_Tu8Sw9KnLraZIhp1ZtS7-K8qt5FekyZ47QW564drQE3a-zhg8NbBVf5u2_kspVon5iyzYXCoWQOG0nc0meNowCo5grGQu8Nsf7NCWhk6KxVq2ypnP_TQn97ZCvkufq44vFS255mMpQycNdLLEbzfdwUBUpqOg9WfHBri2ctnjvUy92klPiFDzBNMO5m50p86hm2ke1NBewLgdmN1LSLQZPic6OvOXeos98Hy88dKDH3w9jpm_H0DyshnZwHv1v2sId_EWcZyU33i57OFDuc_eeM5yyn8USnLNjVCGO858gHX9b0j2s8QdOUbg";
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
}
