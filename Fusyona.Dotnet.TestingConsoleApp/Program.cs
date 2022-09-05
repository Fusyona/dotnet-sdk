// See https://aka.ms/new-console-template for more information
using Microsoft.Identity.Client;
using Fusyona.Dotnet.Sdk.Auth;

AuthenticationResult authenticationResult = await AuthUtils.GetAccessTokenAsync();

Console.WriteLine(authenticationResult.AccessToken);
