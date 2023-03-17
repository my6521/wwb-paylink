namespace WWB.Paylink.BaofPay;

public class BaofPayClient : IBaofPayClient
{
    public const string Name = "WWB.Paylink.BaofPay.Client";

    private readonly IHttpClientFactory _httpClientFactory;

    public BaofPayClient(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<T> ExecuteAsync<T>(IBaofPayRequest<T> request, BaofPayOptions options) where T : BaofPayResponse
    {
        if (options == null)
        {
            throw new ArgumentNullException(nameof(options));
        }

        if (string.IsNullOrEmpty(options.Key))
        {
            throw new BaofPayException($"options.{nameof(BaofPayOptions.Key)} is Empty!");
        }

        var sortedTxtParams = request.GetParameters(options);

        //参数额外处理
        request.PrimaryHandler(sortedTxtParams, options);

        var client = _httpClientFactory.CreateClient(Name);
        var (body, statusCode) = await client.PostAsync(request, sortedTxtParams);

        var parser = new ResponseJsonParser<T>();
        var realContent = ParseRespItem(request, body, options);
        var response = parser.Parse(realContent);

        return response;
    }

    private string ParseRespItem<T>(IBaofPayRequest<T> request, string respBody, BaofPayOptions options) where T : BaofPayResponse
    {
        string realContent;
        if (request.NeedEncrypt)
        {
            realContent = BaofPaySignature.Decrypt(respBody, options);
        }
        else
        {
            realContent = respBody;
        }

        return realContent;
    }
}