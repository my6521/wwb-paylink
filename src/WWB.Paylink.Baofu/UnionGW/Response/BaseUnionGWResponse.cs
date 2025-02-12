using Newtonsoft.Json;
using WWB.Paylink.Utility.Security;

namespace WWB.Paylink.Baofu.UnionGW.Response
{
    public class BaseUnionGWResponse<T> : BaseResponse
    {
        /// <summary>
        /// 宝付提供给商户的唯一编号
        /// </summary>
        [JsonIgnore]
        public string MemberId { get; set; }

        /// <summary>
        /// 服务编号
        /// </summary>
        [JsonIgnore]
        public string ServiceTp { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        [JsonIgnore]
        public string TerminalId { get; set; }

        /// <summary>
        /// 系统返回码
        /// </summary>
        [JsonIgnore]
        public string SysRespCode { get; set; }

        /// <summary>
        /// 系统返回信息
        /// </summary>
        [JsonIgnore]
        public string SysRespDesc { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonIgnore]
        public T Data { get; set; }

        /// <summary>
        /// 处理器
        /// </summary>
        internal override void PrimaryHandler(BaofuOptions options)
        {
            var realContent = RSAUtil.DecryptByCer(base.Raw, options.CerCertificate);
            var result = JsonConvert.DeserializeObject<ResponseDataWraper<T>>(realContent);

            MemberId = result.Header.MemberId;
            ServiceTp = result.Header.ServiceTp;
            TerminalId = result.Header.TerminalId;
            SysRespCode = result.Header.SysRespCode;
            SysRespDesc = result.Header.SysRespDesc;
            Data = result.Body;
        }
    }

    public class BaseUnionGWResponseBody
    {
        /// <summary>
        /// 返回码 1成功 2处理中 0失败
        /// </summary>
        [JsonProperty("retCode")]
        public int RetCode { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误原因
        /// </summary>
        [JsonProperty("errorMsg")]
        public string ErrorMsg { get; set; }

        public string back1 { get; set; }
        public string back2 { get; set; }
        public string back3 { get; set; }
    }
}