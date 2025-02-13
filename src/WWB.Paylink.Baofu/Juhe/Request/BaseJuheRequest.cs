using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WWB.Paylink.Utility;
using WWB.Paylink.Utility.Security;

namespace WWB.Paylink.Baofu.Juhe.Request
{
    public abstract class BaseJuheRequest
    {
        private readonly string _method;

        public BaseJuheRequest(string method)
        {
            _method = method;
        }

        /// <summary>
        /// 代理商商户号
        /// </summary>
        public string agentMerId { get; set; }

        /// <summary>
        /// 代理商终端号
        /// </summary>
        public string agentTerId { get; set; }

        /// <summary>
        /// 交易商户号
        /// </summary>
        [Required]
        public string merId { get; set; }

        /// <summary>
        /// 交易终端号
        /// </summary>
        [Required]
        public string terId { get; set; }

        public virtual string GetContentType()
        {
            return HttpContentType.PostFormUrlencoded;
        }

        public string GetRequestUrl(bool debug)
        {
            return debug ? "https://mch-juhe.baofoo.com/api" : "https://juhe.baofoo.com/api";
        }

        public IDictionary<string, string> PrimaryHandler(BaofuOptions options)
        {
            var dic = new Dictionary<string, string>
            {
                {"merId", options.PayMerId},
                {"terId", options.PayTerId},
                {"method",_method},
                {"charset", "UTF-8"},
                {"version", "1.0"},
                {"format","json"},
                {"timestamp",DateTime.Now.ToString("yyyyMMddHHmmss") },
                {"signType", "RSA"},
                {"signSn", "1"},
                {"ncrptnSn", "1"},
                {"dgtlEnvlp", ""},
            };

            var bizContent = JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
            });

            var encryptStr = RSAUtil.SignByPfx(bizContent, options.PfxCertificate, options.Password);
            dic.Add("signStr", encryptStr);
            dic.Add("bizContent", bizContent);

            return dic;
        }
    }
}