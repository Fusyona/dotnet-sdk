using Microsoft.Identity.Client;

namespace Fusyona.Dotnet.Sdk.Auth;

public static class AuthUtils
{
    private const string clientId = "4063f5d7-c549-4453-a3a5-f039d0eac003";
    private const string tenantId = "f914162d-c0c3-490b-93d5-1d8cfe1a4799";
    private static readonly string[] scopes = { "email", "https://accounts.fusyona.com/api/WriteUserProfileAPI", "https://accounts.fusyona.com/api/ReadUserProfileAPI"};

    public static async Task<string> GetAccessTokenAsync()
    {
        var clientApp = PublicClientApplicationBuilder.Create(clientId)
                        .WithAuthority(AzureCloudInstance.AzurePublic, "f914162d-c0c3-490b-93d5-1d8cfe1a4799")
                        .WithRedirectUri("http://localhost")
                        .Build();

        AuthenticationResult authResult = await clientApp
                                .AcquireTokenInteractive(scopes)
                                .ExecuteAsync();

        string token = authResult.AccessToken;
        return token;
    }
}