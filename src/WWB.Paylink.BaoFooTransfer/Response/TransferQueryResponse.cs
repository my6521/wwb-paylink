using Newtonsoft.Json;
using WWB.Paylink.BaoFooTransfer.Domain;
using WWB.Paylink.BaoFooTransfer.Domain.Response;

namespace WWB.Paylink.BaoFooTransfer.Response
{
    public class TransferQueryResponse : BaseResponse
    {
        /// <summary>
        /// 查询结果对象
        /// </summary>
        [JsonProperty("trans_content")]
        public TransContent<TransQueryRespData> TransContent { get; set; }
    }
}