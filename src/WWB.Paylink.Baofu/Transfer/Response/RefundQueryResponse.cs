using Newtonsoft.Json;
using WWB.Paylink.Baofu.Transfer.Dtos;

namespace WWB.Paylink.Baofu.Transfer.Response
{
    public class RefundQueryResponse
    {
        /// <summary>
        /// 查询结果对象
        /// </summary>
        [JsonProperty("trans_content")]
        public TransContent<RefundQueryRespData> TransContent { get; set; }
    }
}