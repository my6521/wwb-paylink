using WWB.Paylink.Baofu.Juhe.Response;

namespace WWB.Paylink.Baofu.Juhe.Request
{
    public class JuheOrderBalanceQueryRequest : BaseJuheRequest, IBaofuRequest<BaseJuheResponse<JuheOrderBalanceQueryResponse>>
    {
        public JuheOrderBalanceQueryRequest() : base("order_balance_query")
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
        /// 原支付订单宝付订单号
        /// </summary>
        public string originTradeNo { get; set; }

        /// <summary>
        /// 原支付订单商户订单号
        /// </summary>
        public string originOutTradeNo { get; set; }
    }
}