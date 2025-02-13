using WWB.Paylink.Baofu.Juhe.Response;

namespace WWB.Paylink.Baofu.Juhe.Request
{
    public class JuheShareQueryRequest : BaseJuheRequest, IBaofuRequest<BaseJuheResponse<JuheShareQueryResponse>>
    {
        public JuheShareQueryRequest() : base("share_query")
        {
        }

        /// <summary>
        /// 宝付分账交易号
        /// </summary>
        public string tradeNo { get; set; }

        /// <summary>
        /// 商户分账订单号
        /// </summary>
        public string outTradeNo { get; set; }
    }
}