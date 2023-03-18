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
using WWB.Paylink.BaoFooPay.Constants;
using WWB.Paylink.Utility;
using WWB.Paylink.Utility.Security;

namespace WWB.Paylink.BaoFooPay
{
    public class BaoFooPayNotifyClient : IBaoFooPayNotifyClient
    {
        public async Task<TResponse> ExecuteAsync<TResponse>(HttpRequest request, BaoFooPayOptions options) where TResponse : BaseNotify
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            string content = string.Empty;
            if (HttpMethods.IsPost(request.Method))
            {
                using (var reader = new StreamReader(request.Body, Encoding.UTF8, true, 2048, true))
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

                return await ExecuteAsync<TResponse>(content, options);
            }

            throw new BaoFooPayException($"{request.Method} is not Support!");
        }

        public Task<TResponse> ExecuteAsync<TResponse>(string body, BaoFooPayOptions options) where TResponse : BaseNotify
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
                throw new BaoFooPayException($"options.{nameof(BaoFooPayOptions.Key)} is Empty!");
            }

            var notify = JsonConvert.DeserializeObject<TResponse>(body);
            notify.Body = body;
            notify.PrimaryHandler();

            CheckNotifySign(notify, options);

            return Task.FromResult(notify);
        }

        private static void CheckNotifySign(BaseNotify notify, BaoFooPayOptions options)
        {
            if (string.IsNullOrEmpty(notify.Body))
            {
                throw new BaoFooPayException("sign check fail: Body is Empty!");
            }

            var parameters = notify.GetSignatureParameters(options);
            if (parameters.Count == 0)
            {
                throw new BaoFooPayException("sign check fail: Parameters is Empty!");
            }

            if (!parameters.TryGetValue(Consts.SIGN, out var sign))
            {
                throw new BaoFooPayException("sign check fail: sign is Empty!");
            }

            var signContent = ToolHelper.GetSignContent(parameters, options.Key, Consts.SIGN);

            if (!SignatureHelper.VerifySignature(options.CerCertificate, signContent, sign))
            {
                throw new BaoFooPayException("sign check fail: check Sign and Data Fail!");
            }
        }

        private IDictionary<string, string> ToDictionary(NameValueCollection source)
        {
            return source.AllKeys.ToDictionary(k => k, k => source[k]);
        }
    }
}