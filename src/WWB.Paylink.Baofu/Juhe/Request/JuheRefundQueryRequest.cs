using WWB.Paylink.Baofu.Juhe.Response;

namespace WWB.Paylink.Baofu.Juhe.Request
{
    public class JuheRefundQueryRequest : BaseJuheRequest, IBaofuRequest<BaseJuheResponse<JuheRefundQueryResponse>>
    {
        public JuheRefundQueryRequest() : base("refund_query")
        {
        }

        /// <summary>
        /// 退款订单号
        /// </summary>
        public string outTradeNo { get; set; }

        /// <summary>
        /// 宝付订单号
        /// </summary>
        public string tradeNo { get; set; }
    }
}