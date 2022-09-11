
// using Fusyona.Dotnet.Sdk;

// namespace Fusyona.Dotnet.Sdk.Apis.Wallet;

// public static class Wallet
// {
//     private static string baseUrl = "https://wallet-api-dev.azurewebsites.net/api/";
//     private static readonly HttpClient client = new HttpClient();

//     public static async Task<HttpResponseMessage> GetBalanceAsync(
//         string bearerToken, string subcriptionKey, string address_id) 
//     {
//         var request = Utils.ConstructRequest(HttpMethod.Get, bearerToken, 
//             subcriptionKey, baseUrl + $"addresses/{address_id}/balance");

//         return await client.SendAsync(request);
//     }

//     public static async Task<HttpResponseMessage> GetFullBalanceAsync(
//         string bearerToken, string subcriptionKey, string address_id) 
//     {
//         var request = Utils.ConstructRequest(HttpMethod.Get, bearerToken, 
//             subcriptionKey, baseUrl + $"addresses/{address_id}/fullbalance");

//         return await client.SendAsync(request);
//     }

//     public static async Task<HttpResponseMessage> GetClientAddressesAndBalanceAsync(
//         string bearerToken, string subcriptionKey) 
//     {
//         var request = Utils.ConstructRequest(HttpMethod.Get, bearerToken, 
//             subcriptionKey, baseUrl + $"fulladdresses");

//         return await client.SendAsync(request);
//     }

//     public static async Task<HttpResponseMessage> GetCryptocurrenciesAsync(
//         string bearerToken, string subcriptionKey) 
//     {
//         var request = Utils.ConstructRequest(HttpMethod.Get, bearerToken, 
//             subcriptionKey, baseUrl + $"cryptocurrencies");

//         return await client.SendAsync(request);
//     }

//     public static async Task<HttpResponseMessage> GetCryptocurrencySubUnistAsync(
//         string bearerToken, string subcriptionKey, string cryptocurrency_id) 
//     {
//         var request = Utils.ConstructRequest(HttpMethod.Get, bearerToken, 
//             subcriptionKey, baseUrl + $"cryptocurrencies/{cryptocurrency_id}/subunits");

//         return await client.SendAsync(request);
//     }

//     public static async Task<HttpResponseMessage> GetWithdrawalAsync(
//         string bearerToken, string subcriptionKey, string address_id, 
//         string to_public_key, float amount) 
//     {
//         var request = Utils.ConstructRequest(HttpMethod.Get, bearerToken, 
//             subcriptionKey, baseUrl + $"addresses/{address_id}/transfer/{to_public_key}/{amount}");

//         return await client.SendAsync(request);
//     }
// } 
