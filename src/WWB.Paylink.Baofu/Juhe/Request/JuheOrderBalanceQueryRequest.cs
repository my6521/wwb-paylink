using WWB.Paylink.Baofu.Juhe.Response;

namespace WWB.Paylink.Baofu.Juhe.Request
{
    public class JuheOrderBalanceQueryRequest : BaseJuheRequest, IBaofuRequest<BaseJuheResponse<JuheOrderBalanceQueryResponse>>
    {
        public JuheOrderBalanceQueryRequest() : base("order_balance_query")
        {
        }

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