using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using WWB.Paylink.BaoFooPay.Constants;

namespace WWB.Paylink.BaoFooPay
{
    public abstract class BaseNotify : ISignature
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("merchantNo")]
        public string MerchantNo { get; set; }

        [JsonProperty("signType")]
        public string SignType { get; set; }

        [JsonProperty("signContent")]
        public string SignContent { get; set; }

        [JsonProperty("sign")]
        public string Sign { get; set; }

        [JsonIgnore] public string Body { get; set; }

        public IDictionary<string, string> GetSignatureParameters(BaoFooPayOptions options)
        {
            var parameters = new Dictionary<string, string>
            {
                {"method", Method},
                {"version", Version},
                {"format", Format},
                {"merchantNo", MerchantNo},
                {"signType", SignType},
                {"signContent", SignContent},
                {Consts.SIGN, Sign}
            };

            return parameters;
        }

        public abstract void PrimaryHandler();
    }

    public abstract class BaseNotify<TResult> : BaseNotify
    {
        /// <summary>
        /// 结果域
        /// </summary>
        [JsonIgnore]
        public TResult ResultData { get; set; }

        /// <summary>
        /// 执行
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public override void PrimaryHandler()
        {
            if (string.IsNullOrWhiteSpace(SignContent)) throw new ArgumentNullException(nameof(SignContent));

            ResultData = JsonConvert.DeserializeObject<TResult>(SignContent);
        }
    }
}