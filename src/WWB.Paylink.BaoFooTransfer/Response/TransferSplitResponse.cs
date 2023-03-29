using Newtonsoft.Json;
using WWB.Paylink.BaoFooTransfer.Domain;
using WWB.Paylink.BaoFooTransfer.Domain.Response;

namespace WWB.Paylink.BaoFooTransfer.Response
{
    public class TransferSplitResponse : BaseResponse
    {
        /// <summary>
        /// 转账结果
        /// </summary>
        [JsonProperty("trans_content")]
        public TransContent<TransSplitRespData> TransContent { get; set; }
    }
}