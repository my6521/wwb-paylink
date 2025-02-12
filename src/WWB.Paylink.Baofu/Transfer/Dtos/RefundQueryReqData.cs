using Newtonsoft.Json;

namespace WWB.Paylink.Baofu.Transfer.Dtos
{
    public class RefundQueryReqData
    {
        [JsonProperty("trans_btime")]
        public string TransBeginTime { get; set; }

        [JsonProperty("trans_etime")]
        public string TransEndTime { get; set; }
    }
}