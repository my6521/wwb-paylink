using Newtonsoft.Json;

namespace WWB.Paylink.BaoFooTransfer.Domain.Request
{
    public class TransQueryReqData
    {
        /// <summary>
        /// 宝付批次号
        /// </summary>
        [JsonProperty("trans_batchid")] public string TransBatchId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("trans_no")] public string TransNo { get; set; }
    }
}