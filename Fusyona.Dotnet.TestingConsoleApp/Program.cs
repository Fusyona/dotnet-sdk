// See https://aka.ms/new-console-template for more information
using Fusyona.Dotnet.Sdk.Auth;

string token = await AuthUtils.GetAccessTokenAsync();

Console.WriteLine(token);
