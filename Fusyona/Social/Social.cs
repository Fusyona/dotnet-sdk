
using Fusyona;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using Fusyona.Utils;
using Newtonsoft.Json.Linq;
using Fusyona.Social.Models;

namespace Fusyona.Social;

public static class Social
{
    private static readonly string baseUrl = "https://fusyona.azure-api.net/social/v1/";

    public static async Task<IList<PageResponseModel>?> GetPages(
        string bearerToken, string subscriptionKey)
    { 
        return await Common.Request<List<PageResponseModel>>(
            HttpMethod.Get, bearerToken, subscriptionKey, 
            baseUrl + "pages/"
        );
    }

    public static async Task<PageResponseModel?> DeletePage(
        string bearerToken, string subscriptionKey, string pageId)
    { 
        return await Common.Request<PageResponseModel>(
            HttpMethod.Delete, bearerToken, subscriptionKey, 
            baseUrl + $"pages/{pageId}"
        );
    }

    public static async Task<FullPageResponseModel?> GetPage(
        string bearerToken, string subscriptionKey, string pageId)
    { 
        return await Common.Request<FullPageResponseModel>(
            HttpMethod.Get, bearerToken, subscriptionKey, 
            baseUrl + $"pages/{pageId}"
        );
    }
}
