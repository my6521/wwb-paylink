using Newtonsoft.Json;
using WWB.Paylink.BaoFooTransfer.Domain;
using WWB.Paylink.BaoFooTransfer.Domain.Response;

namespace WWB.Paylink.BaoFooTransfer.Response
{
    public class RefundQueryResponse : BaseResponse
    {
        /// <summary>
        /// 查询结果对象
        /// </summary>
        [JsonProperty("trans_content")]
        public TransContent<RefundQueryRespData> TransContent { get; set; }
    }
}