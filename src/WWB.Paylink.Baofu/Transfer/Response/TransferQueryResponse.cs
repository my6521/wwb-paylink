using Newtonsoft.Json;
using WWB.Paylink.Baofu.Transfer.Dtos;

namespace WWB.Paylink.Baofu.Transfer.Response
{
    public class TransferQueryResponse
    {
        /// <summary>
        /// 查询结果对象
        /// </summary>
        [JsonProperty("trans_content")]
        public TransContent<TransQueryRespData> TransContent { get; set; }
    }
}