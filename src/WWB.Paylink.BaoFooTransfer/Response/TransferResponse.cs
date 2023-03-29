using Newtonsoft.Json;
using WWB.Paylink.BaoFooTransfer.Domain;
using WWB.Paylink.BaoFooTransfer.Domain.Response;

namespace WWB.Paylink.BaoFooTransfer.Response
{
    public class TransferResponse : BaseResponse
    {
        /// <summary>
        /// 转账同步返回对象
        /// </summary>
        [JsonProperty("trans_content")]
        public TransContent<TransRespData> TransContent { get; set; }
    }
}