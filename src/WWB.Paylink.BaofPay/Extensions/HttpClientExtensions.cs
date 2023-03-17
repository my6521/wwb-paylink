namespace WWB.Paylink.BaofPay;

public static class HttpClientExtensions
{
    public static async Task<(string body, int statusCode)> PostAsync<T>(this HttpClient client, IBaofPayRequest<T> request, IDictionary<string, string> textParams) where T : BaofPayResponse
    {
        var contentType = request.ContentType;

        string content;

        if (contentType == HttpContentType.PostJson)
        {
            content = BaofPayUtility.BuildContent(textParams);
        }
        else if (contentType == HttpContentType.PostFormUrlencoded)
        {
            content = BaofPayUtility.BuildQuery(textParams);
        }
        else
        {
            throw new BaofPayException($"{contentType} is not Support");
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