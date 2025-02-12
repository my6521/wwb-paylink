using Newtonsoft.Json;
using WWB.Paylink.Baofu.Transfer.Dtos;

namespace WWB.Paylink.Baofu.Transfer.Response
{
    public class TransferSplitResponse
    {
        /// <summary>
        /// 转账结果
        /// </summary>
        [JsonProperty("trans_content")]
        public TransContent<TransSplitRespData> TransContent { get; set; }
    }
}