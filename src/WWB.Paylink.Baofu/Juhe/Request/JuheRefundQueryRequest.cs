using WWB.Paylink.Baofu.Juhe.Response;

namespace WWB.Paylink.Baofu.Juhe.Request
{
    public class JuheRefundQueryRequest : BaseJuheRequest, IBaofuRequest<BaseJuheResponse<JuheRefundQueryResponse>>
    {
        public JuheRefundQueryRequest() : base("refund_query")
        {
        }

        /// <summary>
        /// 代理商商户号
        /// </summary>
        public string agentMerId { get; set; }

        /// <summary>
        /// 代理商终端号
        /// </summary>
        public string agentTerId { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        public string merId { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        public string terId { get; set; }

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