
namespace Fusyona.Dotnet.Sdk.Apis.Wallet;

public static class Wallet
{
    private static string baseUrl = "https://api.fusyona.com/wallet/v1/";
    private static readonly HttpClient client = new HttpClient();

    public static async Task<HttpResponseMessage> GetBalanceAsync(
        string bearerToken, string subcriptionKey, string address_id) 
    {
        var request = Utils.ConstructRequest(HttpMethod.Get, bearerToken, 
            subcriptionKey, baseUrl + $"addresses/{address_id}/balance");

        return await client.SendAsync(request);
    }
} 
