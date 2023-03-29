using Newtonsoft.Json;
using WWB.Paylink.BaoFooTransfer.Domain;
using WWB.Paylink.BaoFooTransfer.Domain.Response;

namespace WWB.Paylink.BaoFooTransfer.Response
{
    public class RefundQueryResponse : BaseResponse
    {
        [JsonProperty("trans_content")]
        public TransContent<RefundQueryRespData> TransContent { get; set; }
    }
}