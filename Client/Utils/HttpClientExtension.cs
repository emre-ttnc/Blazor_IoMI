using Inspection_of_Measuring_Instruments.Shared.Models.ServerResponseModels;
using System.Net.Http.Json;

namespace Inspection_of_Measuring_Instruments.Client.Utils;

public static class HttpClientExtension
{
    public async static Task<ServerResponse<TResult>> PostAndGetServerResponseAsync<TResult, TValue>(this HttpClient httpClient, string url, TValue value)
    {
        HttpResponseMessage? response = await httpClient.PostAsJsonAsync(url, value);
        if (response is not null && response.IsSuccessStatusCode)
        {
            ServerResponse<TResult> result = await response.Content.ReadFromJsonAsync<ServerResponse<TResult>>() ?? new();
            if (result is not null)
                return result;
        }
        return new ServerResponse<TResult>() { Success = false, ErrorMessage = "Something went wrong" };
    }
}
