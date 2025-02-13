using WWB.Paylink.Baofu.Juhe.Response;

namespace WWB.Paylink.Baofu.Juhe.Request
{
    public class JuheOrderQueryRequest : BaseJuheRequest, IBaofuRequest<BaseJuheResponse<JuheOrderQueryResponse>>
    {
        public JuheOrderQueryRequest() : base("order_query")
        {
        }

        /// <summary>
        /// 宝付交易号
        /// </summary>
        public string tradeNo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string outTradeNo { get; set; }
    }
}