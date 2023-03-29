using Newtonsoft.Json;

namespace WWB.Paylink.BaoFooTransfer.Domain.Request
{
    public class RefundQueryReqData
    {
        [JsonProperty("trans_btime")] public string TransBeginTime { get; set; }
        [JsonProperty("trans_etime")] public string TransEndTime { get; set; }
    }
}