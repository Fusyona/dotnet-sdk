
namespace Fusyona.Dotnet.Sdk.Apis.User;

public static class User 
{
    private static string baseUrl = "https://bktuserprofileapi.azurewebsites.net/";
    private static readonly HttpClient client = new HttpClient();

    public static async Task<HttpResponseMessage> GetUserProfile(
        string bearerToken, string subcriptionKey, string user_id) 
    {
        var request = Utils.ConstructRequest(HttpMethod.Get, bearerToken, 
            subcriptionKey, baseUrl + $"users/{user_id}");

        return await client.SendAsync(request);
    }
} 
