using Newtonsoft.Json;
using System.Collections.Generic;
using WWB.Paylink.BaoFooPay.Constants;
using WWB.Paylink.Utility;
using WWB.Paylink.Utility.Security;

namespace WWB.Paylink.BaoFooPay.Request
{
    public abstract class AbstractRequest
    {
        private string version = "1.0";
        private string format = "JSON";
        private string signType = "RSA2";

        /// <summary>
        /// 获取方法名
        /// </summary>
        /// <returns></returns>
        protected abstract string GetMethod();

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public virtual string GetContentType()
        {
            return Paylink.Utility.HttpContentType.PostFormUrlencoded;
        }

        public IDictionary<string, string> PrimaryHandler<T>(T data, BaoFooPayOptions options)
        {
            var parameters = new Dictionary<string, string>
        {
            {"method", GetMethod()},
            {"version", version},
            {"format", format},
            {"merchantNo", options.MerchantNo},
            {"signType", signType},
            {Consts.SIGN_CONTENT, JsonConvert.SerializeObject(data)}
        };

            var signContent = ToolHelper.GetSignContent(parameters, options.Key);
            var sign = SignatureHelper.EncryptByRSA(signContent, options.PfxCertificate, options.Password);

            parameters.Add(Consts.SIGN, sign);

            return parameters;
        }
    }
}