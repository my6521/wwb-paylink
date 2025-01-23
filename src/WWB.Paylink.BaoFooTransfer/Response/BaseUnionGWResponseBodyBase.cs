using Newtonsoft.Json;

namespace WWB.Paylink.BaoFooTransfer.Response
{
    public class BaseUnionGWResponseBodyBase
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