
using Fusyona;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using Fusyona.Utils;
using Newtonsoft.Json.Linq;

namespace Fusyona.Payment;

public static class Payment
{
    private static readonly string baseUrl = "https://fusyona.azure-api.net/pay/v1/";

    public static async Task<string> Checkout(string bearerToken, string subscriptionKey)
    {
        //Send request
        var response = await Common.Request(HttpMethod.Post, bearerToken, subscriptionKey, baseUrl + "Checkout/");
        //Return response
        string apiString = await response.Content.ReadAsStringAsync();
        return apiString;
    }

    public static async Task<string> CheckoutCancel(string bearerToken, string subscriptionKey, string id)
    {
        //Send request
        var response = await Common.Request(HttpMethod.Post, bearerToken, subscriptionKey, baseUrl + $"CheckoutCancel/{id}");
        //Return response
        string apiString = await response.Content.ReadAsStringAsync();
        return apiString;
    }

    public static async Task<string> CheckoutConfirmation(string bearerToken, string subscriptionKey, string id)
    {
        //Send request
        var response = await Common.Request(HttpMethod.Post, bearerToken, subscriptionKey, baseUrl + $"CheckoutConfirmation/{id}");
        //Return response
        string apiString = await response.Content.ReadAsStringAsync();
        return apiString;
    }

    public static async Task<string> ClaimGift(string bearerToken, string subscriptionKey, string tokenId)
    {
        //Send request
        var response = await Common.Request(HttpMethod.Post, bearerToken, subscriptionKey, baseUrl + $"{tokenId}/claim");
        //Return response
        string apiString = await response.Content.ReadAsStringAsync();
        return apiString;
    }

    public static async Task<string> GetInvoices(string bearerToken, string subscriptionKey)
    {
        //Send request
        var response = await Common.Request(HttpMethod.Get, bearerToken, subscriptionKey, baseUrl + "Invoices");
        //Return response
        string apiString = await response.Content.ReadAsStringAsync();
        return apiString;
    }

    public static async Task<string> GetOrders(string bearerToken, string subscriptionKey)
    {
        //Send request
        var response = await Common.Request(HttpMethod.Get, bearerToken, subscriptionKey, baseUrl + "Orders");
        //Return response
        string apiString = await response.Content.ReadAsStringAsync();
        return apiString;
    }
}
