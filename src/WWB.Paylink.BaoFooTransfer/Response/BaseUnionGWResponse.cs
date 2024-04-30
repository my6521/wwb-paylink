using Newtonsoft.Json;
using WWB.Paylink.BaoFooTransfer.Domain;

namespace WWB.Paylink.BaoFooTransfer.Response
{
    public abstract class BaseUnionGWResponse<T> : BaseResponse
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
        public T Body { get; set; }

        /// <summary>
        /// 处理器
        /// </summary>
        internal override void Execute()
        {
            var result = JsonConvert.DeserializeObject<UnionGWResultWraper<T>>(Raw);

            MemberId = result.Header.MemberId;
            ServiceTp = result.Header.ServiceTp;
            TerminalId = result.Header.TerminalId;
            SysRespCode = result.Header.SysRespCode;
            SysRespDesc = result.Header.SysRespDesc;
            Body = result.Body;
        }
    }
}