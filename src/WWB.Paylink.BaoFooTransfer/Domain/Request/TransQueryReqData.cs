using Newtonsoft.Json;

namespace WWB.Paylink.BaoFooTransfer.Domain.Request
{
    public class TransQueryReqData
    {
        [JsonProperty("trans_batchid")] public string TransBatchId { get; set; }
        [JsonProperty("trans_no")] public string TransNo { get; set; }
    }
}