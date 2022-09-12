
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace Fusyona.Utils;

public static class Common
{
    public static HttpRequestMessage ConstructRequest(
        HttpMethod method, string bearerToken, string subscriptionKey, string url, MultipartFormDataContent? content = null)
    {
        var request = new HttpRequestMessage(method, url);

        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
        request.Headers.Add("Ocp-Apim-Trace", "true");
        request.Headers.Add("Ocp-Apim-Subscription-Key", subscriptionKey);
        request.Content = content;

        return request;
    }

    public static async Task<T?> Request<T>(
        HttpMethod method, string bearerToken, string subscriptionKey, string url, MultipartFormDataContent? content = null)
    {
        var response = default(T);

        var responseMessage = await Request(method, bearerToken, subscriptionKey, url, content);

        if (responseMessage.IsSuccessStatusCode)
        {
            string responseString = await responseMessage.Content
                .ReadAsStringAsync();

            response = JsonConvert.DeserializeObject<T>(responseString);
        }
        else
        {
            throw new Exception(responseMessage.ToString());
        }

        return response;
    }

    public static async Task<HttpResponseMessage?> Request(
        HttpMethod method, string bearerToken, string subcriptionKey, string url, MultipartFormDataContent? content = null)
    {
        
        using (var client = new HttpClient())
        {
            var request = ConstructRequest(
                method, bearerToken, subcriptionKey, url, content
            );

            var responseMessage = await client.SendAsync(request);

            return responseMessage;
        }
    }
}

