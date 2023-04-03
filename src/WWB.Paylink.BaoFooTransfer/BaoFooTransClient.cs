using System;
using System.Net.Http;
using System.Threading.Tasks;
using WWB.Paylink.BaoFooTransfer.Parser;
using WWB.Paylink.Utility;
using WWB.Paylink.Utility.Security;

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

        public async Task<T> ExecuteAsync<T>(IBaoFooTransRequest<T> request, BaoFooTransOptions options) where T : BaseResponse
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            //获取参数
            var txtParams = request.PrimaryHandler(options);
            //获取请求url
            var url = request.GetRequestUrl(options.Debug);
            //获取提交类型
            var contentType = request.GetContentType();
            //提交
            var client = _httpClientFactory.CreateClient(Name);
            var (body, isSuccessStatusCode) = await client.PostAsync(url, contentType, txtParams);
            //解密
            var realContent = RSAHelper.DecryptByCer(body, options.CerCertificate);
            //反序列化
            var parser = new ResponseJsonParser<T>();
            var response = parser.Parse(realContent);

            return response;
        }
    }
}