namespace WWB.Paylink.HsqPay;

public class HsqPayClient : IHsqPayClient
{
    public const string Name = "WWB.Paylink.HsqPay.Client";

    private readonly IHttpClientFactory _httpClientFactory;

    public HsqPayClient(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<T> ExecuteAsync<T>(IHsqPayRequest<T> request, HsqPayOptions options) where T : HsqPayResponse
    {
        if (options == null)
        {
            throw new ArgumentNullException(nameof(options));
        }

        if (string.IsNullOrEmpty(options.Key))
        {
            throw new HsqPayException($"options.{nameof(HsqPayOptions.Key)} is Empty!");
        }

        var txtParams = request.GetParameters(options);

        // 序列化BizModel
        txtParams = SerializeBizModel(txtParams, request);

        // 添加签名参数
        txtParams.Add(HsqPayConsts.SIGN, HsqPaySignature.RSASignContent(txtParams, options, request.SignType));

        var client = _httpClientFactory.CreateClient(Name);
        var (body, statusCode) = await client.PostAsync(request, txtParams);
        var parser = new HsqPayResponseJsonParser<T>();
        var response = parser.Parse(body, statusCode);

        if (statusCode == 200 && request.NeedCheckSign)
        {
            var signType = request.SignType;

            CheckResponseSign(response, options, signType);
        }

        return response;
    }

    private static IDictionary<string, string> SerializeBizModel<T>(IDictionary<string, string> requestParams, IHsqPayRequest<T> request) where T : HsqPayResponse
    {
        var result = requestParams;
        var isBizContentEmpty = !requestParams.ContainsKey(HsqPayConsts.SIGN_CONTENT) || string.IsNullOrEmpty(requestParams[HsqPayConsts.SIGN_CONTENT]);
        var bizModel = request.GetBizModel();
        if (isBizContentEmpty && bizModel != null)
        {
            var content = JsonConvert.SerializeObject(bizModel);
            result.Add(HsqPayConsts.SIGN_CONTENT, content);
        }

        return result;
    }

    private static void CheckResponseSign(HsqPayResponse response, HsqPayOptions options, string signType)
    {
        if (string.IsNullOrEmpty(response.Body))
        {
            throw new HsqPayException("sign check fail: Body is Empty!");
        }

        var param = response.GetParameters();

        if (!param.TryGetValue(HsqPayConsts.SIGN, out var sign))
        {
            throw new HsqPayException("sign check fail: sign is Empty!");
        }

        if (!HsqPaySignature.RSACheckContent(param, sign, options, signType))
        {
            throw new HsqPayException("sign check fail: check Sign and Data Fail!");
        }
    }
}