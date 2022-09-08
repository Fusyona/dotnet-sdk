
using Fusyona.Dotnet.Sdk;

namespace Fusyona.Dotnet.Sdk.Apis.Token;

public static class Token 
{
    private static string baseUrl = "https://api.fusyona.com/utility/v1/";
    private static readonly HttpClient client = new HttpClient();

    public static async Task<HttpResponseMessage> CreateERC20(
        string bearerToken, string subcriptionKey) 
    {
        var request = Utils.ConstructRequest(HttpMethod.Get, bearerToken, 
            subcriptionKey, baseUrl + $"erc20");

        return await client.SendAsync(request);
    }
} 
