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
        public string memberId { get; set; }

        /// <summary>
        /// 服务编号
        /// </summary>
        public string serviceTp { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        public string terminalId { get; set; }

        /// <summary>
        /// 系统返回码
        /// </summary>
        public string sysRespCode { get; set; }

        /// <summary>
        /// 系统返回信息
        /// </summary>
        public string sysRespDesc { get; set; }
    }
}