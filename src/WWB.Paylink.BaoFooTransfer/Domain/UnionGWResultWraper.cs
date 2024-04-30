using Newtonsoft.Json;

namespace WWB.Paylink.BaoFooTransfer.Domain
{
    public class UnionGWResultWraper<TBody>
    {
        /// <summary>
        /// 内容
        /// </summary>
        [JsonProperty("body")]
        public TBody Body { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("header")]
        public UnionGWResultHeader Header { get; set; }
    }

    public class UnionGWResultHeader
    {
        /// <summary>
        /// 宝付提供给商户的唯一编号
        /// </summary>
        [JsonProperty("memberId")]
        public string MemberId { get; set; }

        /// <summary>
        /// 服务编号
        /// </summary>
        [JsonProperty("serviceTp")]
        public string ServiceTp { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        [JsonProperty("terminalId")]
        public string TerminalId { get; set; }

        /// <summary>
        /// 系统返回码
        /// </summary>
        [JsonProperty("sysRespCode")]
        public string SysRespCode { get; set; }

        /// <summary>
        /// 系统返回信息
        /// </summary>
        [JsonProperty("sysRespDesc")]
        public string SysRespDesc { get; set; }
    }
}