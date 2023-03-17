namespace WWB.Paylink.BaofPay;

public class BaofPayNotifyClient : IBaofPayNotifyClient
{
    public async Task<T> ExecuteAsync<T>(HttpRequest request, BaofPayOptions options) where T : BaofPayNotify
    {
        if (request == null)
        {
            throw new ArgumentNullException(nameof(request));
        }

        if (HttpMethods.IsPost(request.Method))
        {
            using (var reader = new StreamReader(request.Body, Encoding.UTF8, true, 1024, true))
            {
                var body = await reader.ReadToEndAsync();

                var parsed = HttpUtility.ParseQueryString(body);

                var json = JsonConvert.SerializeObject(ToDictionary(parsed));

                return await ExecuteAsync<T>(json, options);
            }
        }

        if (HttpMethods.IsGet(request.Method))
        {
            var parsed = HttpUtility.ParseQueryString(HttpUtility.UrlDecode(HttpUtility.UrlDecode(request.QueryString.Value)));

            var json = JsonConvert.SerializeObject(ToDictionary(parsed));

            return await ExecuteAsync<T>(json, options);
        }

        throw new BaofPayException($"{request.Method} is not Support!");
    }

    public Task<T> ExecuteAsync<T>(string body, BaofPayOptions options) where T : BaofPayNotify
    {
        if (string.IsNullOrEmpty(body))
        {
            throw new ArgumentNullException(nameof(body));
        }

        if (options == null)
        {
            throw new ArgumentNullException(nameof(options));
        }

        if (string.IsNullOrEmpty(options.Key))
        {
            throw new BaofPayException($"options.{nameof(BaofPayOptions.Key)} is Empty!");
        }

        var parser = new NotifyJsonParser<T>();

        //反序列化
        var notify = parser.Parse(body, options);

        return Task.FromResult(notify);
    }

    private IDictionary<string, string> ToDictionary(NameValueCollection source)
    {
        return source.AllKeys.ToDictionary(k => k, k => source[k]);
    }
}