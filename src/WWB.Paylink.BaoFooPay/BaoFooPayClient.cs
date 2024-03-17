using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WWB.Paylink.BaoFooPay.Constants;
using WWB.Paylink.Utility;
using WWB.Paylink.Utility.Security;

namespace WWB.Paylink.BaoFooPay
{
    public class BaoFooPayClient : IBaoFooPayClient
    {
        public const string Name = "WWB.Paylink.BaoFooPay.Client";

        private readonly IHttpClientFactory _httpClientFactory;

        public BaoFooPayClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<TResponse> ExecuteAsync<TResponse>(IBaoFooPayRequest<TResponse> request, BaoFooPayOptions options) where TResponse : BaseResponse
        {
            VerifyOptions(options);

            //获取参数
            var txtParams = request.PrimaryHandler(options);

            //获取请求url
            var url = request.GetRequestUrl(options.Debug);

            //获取提交类型
            var contentType = request.GetContentType();

            using (var client = _httpClientFactory.CreateClient(Name))
            {
                var (body, isSuccessStatusCode) = await client.PostAsync(url, contentType, txtParams);

                if (isSuccessStatusCode)
                {
                    var rootResult = JsonConvert.DeserializeObject<TResponse>(body);
                    CheckResponseSign(rootResult, options);
                    rootResult.PrimaryHandler();

                    return rootResult;
                }

                var result = Activator.CreateInstance<TResponse>();
                result.ErrorCode = "SYSTEM_INNER_ERROR";
                result.ErrorMsg = body;

                return result;
            }
        }

        private void VerifyOptions(BaoFooPayOptions options)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.Key))
            {
                throw new BaoFooPayException($"options.{nameof(BaoFooPayOptions.Key)} is Empty!");
            }
        }

        private static void CheckResponseSign(BaseResponse response, BaoFooPayOptions options)
        {
            var parameters = response.GetSignatureParameters(options);

            if (!parameters.TryGetValue(Consts.SIGN, out var sign))
            {
                throw new BaoFooPayException("sign check fail: sign is Empty!");
            }

            var signContent = ToolHelper.GetSignContent(parameters, options.Key, Consts.SIGN);

            if (!RSAUtil.VerifyByCer(options.CerCertificate, signContent, sign))
            {
                throw new BaoFooPayException("sign check fail: check Sign and Data Fail!");
            }
        }
    }
}