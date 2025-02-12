using Newtonsoft.Json;
using WWB.Paylink.Baofu.Transfer.Dtos;

namespace WWB.Paylink.Baofu.Transfer.Response
{
    public class TransferResponse
    {
        /// <summary>
        /// 转账同步返回对象
        /// </summary>
        [JsonProperty("trans_content")]
        public TransContent<TransRespData> TransContent { get; set; }
    }
}