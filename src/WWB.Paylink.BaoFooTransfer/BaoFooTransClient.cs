namespace WWB.Paylink.BaoFooTransfer
{
    public class BaoFooTransClient : IBaoFooTransClient
    {
        public const string Name = "WWB.Paylink.BaoFooTransfer.Client";

        private readonly IHttpClientFactory _httpClientFactory;

        public BaoFooTransClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<T> ExecuteAsync<T>(IRequest<T> request, BaoFooTransOptions options) where T : BaseResponse
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.Key))
            {
                throw new BaoFooTransException($"options.{nameof(BaoFooTransOptions.Key)} is Empty!");
            }

            //获取参数
            var txtParams = request.PrimaryHandler(options);
            //获取请求url
            var url = request.GetRequestUrl(options.Debug);
            //获取提交类型
            var contentType = request.GetContentType();

            var client = _httpClientFactory.CreateClient(Name);
            var (body, isSuccessStatusCode) = await client.PostAsync(url, contentType, txtParams);
            var parser = new ResponseJsonParser<T>();
            var realContent = RSAHelper.DecryptByCer(body, options.CerCertificate);
            var response = parser.Parse(realContent);

            return response;
        }
    }
}