
using Fusyona;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using Fusyona.Utils;
using Newtonsoft.Json.Linq;
using Fusyona.Nft.Models;

namespace Fusyona.UtilityToken;

public static class UtilityToken
{
    private static readonly string baseUrl = "https://fusyona.azure-api.net/utility/v1/";

    public static async Task<string> CreateERC20(string bearerToken, string subscriptionKey)
    {
        //Send request
        var response = await Common.Request(HttpMethod.Post, bearerToken, subscriptionKey, baseUrl + "erc20/");
        //Return response
        string apiString = await response.Content.ReadAsStringAsync();
        return apiString;
    }
}
