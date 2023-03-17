using WWB.Paylink.BaoFooPay.Constants;
using WWB.Paylink.BaoFooPay.Utility;

namespace WWB.Paylink.BaoFooPay;

public class HsqPayNotifyClient : IHsqPayNotifyClient
{
    public async Task<T> ExecuteAsync<T>(HttpRequest request, HsqPayOptions options) where T : BaseNotify
    {
        if (request == null)
        {
            throw new ArgumentNullException(nameof(request));
        }

        string content = string.Empty;
        if (HttpMethods.IsPost(request.Method))
        {
            using (var reader = new StreamReader(request.Body, Encoding.UTF8, true, 1024, true))
            {
                content = await reader.ReadToEndAsync();
            }
        }
        else if (HttpMethods.IsGet(request.Method))
        {
            content = request.QueryString.Value;
        }

        if (!string.IsNullOrWhiteSpace(content))
        {
            var parsed = HttpUtility.ParseQueryString(HttpUtility.UrlDecode(content));
            var json = JsonConvert.SerializeObject(ToDictionary(parsed));

            return await ExecuteAsync<T>(content, options);
        }

        throw new HsqPayException($"{request.Method} is not Support!");
    }

    public Task<T> ExecuteAsync<T>(string body, HsqPayOptions options) where T : BaseNotify
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

        var notify = JsonConvert.DeserializeObject<T>(body);
        notify.Body = body;
        notify.Execute();

        CheckNotifySign(notify, options);

        return Task.FromResult(notify);
    }

    private static void CheckNotifySign(BaseNotify notify, HsqPayOptions options)
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

        if (!parameters.TryGetValue(Consts.SIGN, out var sign))
        {
            throw new HsqPayException("sign check fail: sign is Empty!");
        }

        if (!Signature.RSACheckContent(parameters, sign, options))
        {
            throw new HsqPayException("sign check fail: check Sign and Data Fail!");
        }
    }

    private IDictionary<string, string> ToDictionary(NameValueCollection source)
    {
        return source.AllKeys.ToDictionary(k => k, k => source[k]);
    }
}