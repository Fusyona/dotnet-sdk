
using System.Net.Http.Headers;

namespace Fusyona.Dotnet.Sdk;

public static class Utils 
{
    public static HttpRequestMessage ConstructRequest(
        HttpMethod method, string bearerToken, string subcriptionKey, string url) 
    {
        var request = new HttpRequestMessage(method, url);

        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
        request.Headers.Add("Ocp-Apim-Trace", "true");
        request.Headers.Add("Ocp-Apim-Subscription-Key", subcriptionKey);

        return request;
    }
} 

