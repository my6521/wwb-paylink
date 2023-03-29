using Newtonsoft.Json;
using WWB.Paylink.BaoFooTransfer.Domain;
using WWB.Paylink.BaoFooTransfer.Domain.Response;

namespace WWB.Paylink.BaoFooTransfer.Response
{
    public class TransferSplitResponse : BaseResponse
    {
        [JsonProperty("trans_content")]
        public TransContent<TransSplitRespData> TransContent { get; set; }
    }
}