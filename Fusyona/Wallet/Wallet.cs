
using Fusyona;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using Fusyona.Utils;
using Newtonsoft.Json.Linq;
using Fusyona.Nft.Models;

namespace Fusyona.Wallet;

public static class Wallet
{
    private static readonly string baseUrl = "https://fusyona.azure-api.net/wallet/v1/";

    public static async Task<string> GetBalanceAsync(string bearerToken, string subscriptionKey, string addressId)
    {
        //Send request
        var response = await Common.Request(HttpMethod.Get, bearerToken, subscriptionKey, baseUrl + "addresses/{addressId}/balance");
        //Return response
        string apiString = await response.Content.ReadAsStringAsync();
        return apiString;
    }

    public static async Task<string> GetFullBalanceAsync(string bearerToken, string subscriptionKey, string addressId)
    {
        //Send request
        var response = await Common.Request(HttpMethod.Get, bearerToken, subscriptionKey, baseUrl + "addresses/{addressId}/fullbalance");
        //Return response
        string apiString = await response.Content.ReadAsStringAsync();
        return apiString;
    }

    public static async Task<string> GetClientAddressesAndBalanceAsync(string bearerToken, string subscriptionKey)
    {
        //Send request
        var response = await Common.Request(HttpMethod.Get, bearerToken, subscriptionKey, baseUrl + "fulladdresses");
        //Return response
        string apiString = await response.Content.ReadAsStringAsync();
        return apiString;
    }

    public static async Task<string> GetCryptocurrenciesAsync(string bearerToken, string subscriptionKey)
    {
        //Send request
        var response = await Common.Request(HttpMethod.Get, bearerToken, subscriptionKey, baseUrl + "cryptocurrencies");
        //Return response
        string apiString = await response.Content.ReadAsStringAsync();
        return apiString;
    }

    public static async Task<string> GetCryptocurrencySubUnistAsync(string bearerToken, string subscriptionKey, string cryptocurencyId)
    {
        //Send request
        var response = await Common.Request(HttpMethod.Get, bearerToken, subscriptionKey, baseUrl + "cryptocurrencies/{cryptocurrencyId}/subunits");
        //Return response
        string apiString = await response.Content.ReadAsStringAsync();
        return apiString;
    }

    public static async Task<string> WithdrawalAsync(string bearerToken, string subscriptionKey, string addressId, string publicKey, int amount)
    {
        //Send request
        var response = await Common.Request(HttpMethod.Post, bearerToken, subscriptionKey, baseUrl + "addresses/{addressId}/transfer/{publicKey}/{amount}");
        //Return response
        string apiString = await response.Content.ReadAsStringAsync();
        return apiString;
    }
    
}
