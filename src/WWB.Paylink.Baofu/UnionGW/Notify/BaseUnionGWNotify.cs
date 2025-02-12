﻿using Newtonsoft.Json;
using WWB.Paylink.Utility.Security;

namespace WWB.Paylink.Baofu.UnionGW.Notify
{
    public class BaseUnionGWNotify<T> : BaseNotify
    {
        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        [JsonProperty("terminal_id")]
        public string TerminalId { get; set; }

        /// <summary>
        /// 数据类型。xml或json
        /// </summary>
        [JsonProperty("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 请求报文（加密串）
        /// </summary>
        [JsonProperty("data_content")]
        public string DataContent { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// 返回结果对象
        /// </summary>
        [JsonIgnore]
        public T Data { get; set; }

        internal override void PrimaryHandler(BaofuOptions options)
        {
            if (string.IsNullOrWhiteSpace(DataContent)) return;

            //解密data_content
            DataContent = RSAUtil.DecryptByCer(DataContent, options.CerCertificate);
            Data = JsonConvert.DeserializeObject<T>(DataContent);
        }
    }
}