using System;
using System.Net.Http;
using System.Threading.Tasks;
using WWB.Paylink.JoinPay.Parser;
using WWB.Paylink.Utility;

namespace WWB.Paylink.JoinPay
{
    public class JoinPayClient : IJoinPayClient
    {
        public const string Name = "WWB.Paylink.JoinPay.Client";

        private readonly IHttpClientFactory _httpClientFactory;

        public JoinPayClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<T> ExecuteAsync<T>(IJoinPayRequest<T> request, JoinPayOptions options) where T : JoinPayResponse
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.APIKey))
            {
                throw new JoinPayException($"options.{nameof(JoinPayOptions.APIKey)} is Empty!");
            }

            var sortedTxtParams = request.GetParameters();

            request.PrimaryHandler(sortedTxtParams, options);

            //获取请求url
            var url = request.GetRequestUrl(options.Debug);

            //获取提交类型
            var contentType = request.GetContentType();

            var client = _httpClientFactory.CreateClient(Name);
            var (body, isSuccessStatusCode) = await client.PostAsync(url, contentType, sortedTxtParams);
            if (!isSuccessStatusCode)
            {
                throw new JoinPayException($"SYSTEM_INNER_ERROR：{body}");
            }

            var parser = new JoinPayResponseJsonParser<T>();
            var response = parser.Parse(body);

            if (request.GetNeedCheckSign())
            {
                var signType = request.GetSignType();
                CheckResponseSign(response, options, signType);
            }

            return response;

        }

        #region Check Response Method

        private static void CheckResponseSign(JoinPayResponse response, JoinPayOptions options, JoinPaySignType signType)
        {
            if (string.IsNullOrEmpty(response.Body))
            {
                throw new JoinPayException("sign check fail: Body is Empty!");
            }

            var param = response.GetParameters();

            if (!param.TryGetValue(JoinPayConsts.sign, out var sign))
            {
                throw new JoinPayException("sign check fail: sign is Empty!");
            }

            var cal_sign = JoinPaySignature.SignWithKey(param, options.APIKey, signType);
            if (!cal_sign.Equals(sign, StringComparison.OrdinalIgnoreCase))
            {
                throw new JoinPayException("sign check fail: check Sign and Data Fail!");
            }
        }

        #endregion Check Response Method
    }
}