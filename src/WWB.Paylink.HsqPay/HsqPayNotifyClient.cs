namespace WWB.Paylink.HsqPay;

public class HsqPayNotifyClient : IHsqPayNotifyClient
{
    public async Task<T> ExecuteAsync<T>(HttpRequest request, HsqPayOptions options) where T : HsqPayNotify
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

                return await ExecuteAsync<T>(body, options);
            }
        }

        if (HttpMethods.IsGet(request.Method))
        {
            var parsed = HttpUtility.ParseQueryString(HttpUtility.UrlDecode(HttpUtility.UrlDecode(request.QueryString.Value)));

            var json = JsonConvert.SerializeObject(ToDictionary(parsed));

            return await ExecuteAsync<T>(json, options);
        }

        throw new HsqPayException($"{request.Method} is not Support!");
    }

    public Task<T> ExecuteAsync<T>(string body, HsqPayOptions options) where T : HsqPayNotify
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
            throw new HsqPayException($"options.{nameof(HsqPayOptions.Key)} is Empty!");
        }

        var parser = new HsqPayNotifyJsonParser<T>();
        var notify = parser.Parse(body);

        CheckNotifySign(notify, options);

        return Task.FromResult(notify);
    }

    private static void CheckNotifySign(HsqPayNotify notify, HsqPayOptions options)
    {
        if (string.IsNullOrEmpty(notify.Body))
        {
            throw new HsqPayException("sign check fail: Body is Empty!");
        }

        var parameters = notify.GetParameters();
        if (parameters.Count == 0)
        {
            throw new HsqPayException("sign check fail: Parameters is Empty!");
        }

        if (!parameters.TryGetValue(HsqPayConsts.SIGN, out var sign))
        {
            throw new HsqPayException("sign check fail: sign is Empty!");
        }

        if (!HsqPaySignature.RSACheckContent(parameters, sign, options, null))
        {
            throw new HsqPayException("sign check fail: check Sign and Data Fail!");
        }
    }

    private IDictionary<string, string> ToDictionary(NameValueCollection source)
    {
        return source.AllKeys.ToDictionary(k => k, k => source[k]);
    }
}