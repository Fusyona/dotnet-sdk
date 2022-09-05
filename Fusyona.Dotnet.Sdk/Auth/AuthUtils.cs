using Microsoft.Identity.Client;

namespace Fusyona.Dotnet.Sdk.Auth;

public static class AuthUtils
{
    // Azure AD B2C Coordinates
    private static string Tenant = "fusyona.onmicrosoft.com";
    private static string AzureADB2CHostname = "fusyona.b2clogin.com";
    private static string ClientID = "4063f5d7-c549-4453-a3a5-f039d0eac003";
    private static string PolicySignUpSignIn = "B2C_1_SignUpIn";
    private static string AuthorityBase = $"https://{AzureADB2CHostname}/tfp/{Tenant}/";
    private static string Authority = $"{AuthorityBase}{PolicySignUpSignIn}";
    private static string TenantId = "f914162d-c0c3-490b-93d5-1d8cfe1a4799/B2C_1_SignUpIn";
    private static readonly string[] Scopes = { "openid", "profile", "email", "https://accounts.fusyona.com/api/WriteUserProfileAPI", "https://accounts.fusyona.com/api/ReadUserProfileAPI"};
    public static async Task<AuthenticationResult> GetAccessTokenAsync()
    {
        var application = PublicClientApplicationBuilder.Create(ClientID)
               .WithB2CAuthority(Authority)
               .WithRedirectUri("http://localhost")
               .Build();

        AuthenticationResult? authResult = null;
        IEnumerable<IAccount> accounts = await application.GetAccountsAsync(PolicySignUpSignIn);
        IAccount? account = accounts.FirstOrDefault();
        try
        {
            authResult = await application.AcquireTokenSilent(Scopes, account)
                              .ExecuteAsync();
        }
        catch (MsalUiRequiredException ex)
        {
            authResult = await application.AcquireTokenInteractive(Scopes)
                                .ExecuteAsync();
        }

        return authResult;
    }
}