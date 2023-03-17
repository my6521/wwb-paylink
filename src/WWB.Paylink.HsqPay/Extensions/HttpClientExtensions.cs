namespace WWB.Paylink.HsqPay.Extensions;

public static class HttpClientExtensions
{
    public static async Task<(string body, int statusCode)> PostAsync<T>(this HttpClient client, IHsqPayRequest<T> request, IDictionary<string, string> textParams) where T : HsqPayResponse
    {
        var contentType = request.ContentType;

        string content;

        if (contentType == HttpContentType.PostJson)
        {
            content = HsqPayUtility.BuildContent(textParams);
        }
        else if (contentType == HttpContentType.PostFormUrlencoded)
        {
            content = HsqPayUtility.BuildQuery(textParams);
        }
        else
        {
            throw new HsqPayException($"{contentType} is not Support");
        }

        using (var reqContent = new StringContent(content, Encoding.UTF8, contentType))
        {
            using (var resp = await client.PostAsync(request.RequestUrl, reqContent))
            {
                using (var respContent = resp.Content)
                {
                    var statusCode = (int)resp.StatusCode;
                    var body = await respContent.ReadAsStringAsync();
                    return (body, statusCode);
                }
            }
        }
    }
}