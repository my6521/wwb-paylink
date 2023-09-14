using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WWB.Paylink.JoinPay.Parser;

namespace WWB.Paylink.JoinPay
{
    public class JoinPayNotifyClient : IJoinPayNotifyClient
    {
        public async Task<T> ExecuteAsync<T>(HttpRequest request, JoinPayOptions options) where T : JoinPayNotify
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

            throw new JoinPayException($"{request.Method} is not Support!");
        }

        public Task<T> ExecuteAsync<T>(string body, JoinPayOptions options) where T : JoinPayNotify
        {
            if (string.IsNullOrEmpty(body))
            {
                throw new ArgumentNullException(nameof(body));
            }

            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.APIKey))
            {
                throw new JoinPayException($"options.{nameof(JoinPayOptions.APIKey)} is Empty!");
            }

            var parser = new JoinPayNotifyJsonParser<T>();
            var notify = parser.Parse(body);
            CheckNotifySign(notify, options);

            return Task.FromResult(notify);
        }

        private static void CheckNotifySign(JoinPayNotify notify, JoinPayOptions options)
        {
            if (string.IsNullOrEmpty(notify.Body))
            {
                throw new JoinPayException("sign check fail: Body is Empty!");
            }

            var parameters = notify.GetParameters();
            if (parameters.Count == 0)
            {
                throw new JoinPayException("sign check fail: Parameters is Empty!");
            }

            if (!parameters.TryGetValue(JoinPayConsts.sign, out var sign))
            {
                throw new JoinPayException("sign check fail: sign is Empty!");
            }

            string cal_sign = JoinPaySignature.SignWithKey(parameters, options.APIKey, JoinPaySignType.MD5);

            if (!cal_sign.Equals(sign, StringComparison.OrdinalIgnoreCase))
            {
                throw new JoinPayException("sign check fail: check Sign and Data Fail!");
            }
        }

        private IDictionary<string, string> ToDictionary(NameValueCollection source)
        {
            return source.AllKeys.ToDictionary(k => k, k => source[k]);
        }
    }
}