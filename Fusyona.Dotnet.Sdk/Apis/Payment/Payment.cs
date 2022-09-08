
using Fusyona.Dotnet.Sdk;

namespace Fusyona.Dotnet.Sdk.Apis.Payment;

public static class Payment 
{
    private static string baseUrl = "https://api.fusyona.com/pay/v1/";
    private static readonly HttpClient client = new HttpClient();

    public static async Task<HttpResponseMessage> PostCheckout(
        string bearerToken, string subcriptionKey) 
    {
        var request = Utils.ConstructRequest(HttpMethod.Post, bearerToken, 
            subcriptionKey, baseUrl + "Checkout");

        return await client.SendAsync(request);
    }

    public static async Task<HttpResponseMessage> PostCheckoutCancel(
        string bearerToken, string subcriptionKey, string id) 
    {
        var request = Utils.ConstructRequest(HttpMethod.Post, bearerToken, 
            subcriptionKey, baseUrl + $"CheckoutCancel/{id}");

        return await client.SendAsync(request);
    }

    public static async Task<HttpResponseMessage> PostCheckoutConfirmation(
        string bearerToken, string subcriptionKey, string id) 
    {
        var request = Utils.ConstructRequest(HttpMethod.Post, bearerToken, 
            subcriptionKey, baseUrl + $"CheckoutConfirmation/{id}");

        return await client.SendAsync(request);
    }

    public static async Task<HttpResponseMessage> PostClaimGift(
        string bearerToken, string subcriptionKey, string tokenId) 
    {
        var request = Utils.ConstructRequest(HttpMethod.Post, bearerToken, 
            subcriptionKey, baseUrl + $"{tokenId}/claim");

        return await client.SendAsync(request);
    }

    public static async Task<HttpResponseMessage> GetInvoices(
        string bearerToken, string subcriptionKey) 
    {
        var request = Utils.ConstructRequest(HttpMethod.Get, bearerToken, 
            subcriptionKey, baseUrl + "Invoices");

        return await client.SendAsync(request);
    }

    public static async Task<HttpResponseMessage> GetOrders(
        string bearerToken, string subcriptionKey) 
    {
        var request = Utils.ConstructRequest(HttpMethod.Get, bearerToken, 
            subcriptionKey, baseUrl + "Orders");

        return await client.SendAsync(request);
    }
} 
