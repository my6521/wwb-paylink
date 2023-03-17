namespace WWB.Paylink.BaoFooPay;

public class HsqPayClient : IHsqPayClient
{
    public const string Name = "WWB.Paylink.BaoFooPay.Client";

    private readonly IHttpClientFactory _httpClientFactory;

    public HsqPayClient(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<TResponse> ExecuteAsync<TResponse>(IRequest<TResponse> request, HsqPayOptions options) where TResponse : BaseResponse
    {
        VerifyOptions(options);

        //获取参数
        var txtParams = request.PrimaryHandler(options);

        //获取请求url
        var url = request.GetRequestUrl(options.Debug);

        //获取提交类型
        var contentType = request.GetContentType();

        var client = _httpClientFactory.CreateClient(Name);

        var (body, isSuccessStatusCode) = await client.PostAsync(url, contentType, txtParams);

        if (isSuccessStatusCode)
        {
            var rootResult = JsonConvert.DeserializeObject<TResponse>(body);

            return rootResult;
        }

        var result = Activator.CreateInstance<TResponse>();
        result.ErrorCode = "SYSTEM_INNER_ERROR";
        result.ErrorMsg = body;

        return result;
    }

    private void VerifyOptions(HsqPayOptions options)
    {
        if (options == null)
        {
            throw new ArgumentNullException(nameof(options));
        }

        if (string.IsNullOrEmpty(options.Key))
        {
            throw new HsqPayException($"options.{nameof(HsqPayOptions.Key)} is Empty!");
        }
    }
}