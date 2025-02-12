﻿using Newtonsoft.Json;
using WWB.Paylink.Utility.Security;

namespace WWB.Paylink.Baofu.Juhe.Response
{
    public class BaseJuheResponse : BaseResponse
    {
        public string returnCode { get; set; }
        public string returnMsg { get; set; }
        public string merId { get; set; }
        public string terId { get; set; }
        public string charset { get; set; }
        public string version { get; set; }
        public string format { get; set; }
        public string signType { get; set; }
        public string signSn { get; set; }
        public string ncrptnSn { get; set; }
        public string dgtlEnvlp { get; set; }
        public string signStr { get; set; }
        public string dataContent { get; set; }
    }

    public class BaseJuheResponse<T> : BaseJuheResponse
    {
        [JsonIgnore]
        public T Data { get; set; }

        /// <summary>
        /// 处理器
        /// </summary>
        internal override void PrimaryHandler(BaofuOptions options)
        {
            var result = JsonConvert.DeserializeObject<BaseJuheResponse>(Raw);
            if (result.returnCode == "SUCCESS")
            {
                if (!RSAUtil.VerifyByCer(options.CerCertificate, result.dataContent, result.signStr))
                {
                    throw new BaofuException("sign check fail: check Sign and Data Fail!");
                }

                this.returnCode = result.returnCode;
                this.returnMsg = result.returnMsg;

                this.Data = JsonConvert.DeserializeObject<T>(result.dataContent);
            }
        }
    }
}