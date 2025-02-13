using WWB.Paylink.Baofu.Juhe.Response;

namespace WWB.Paylink.Baofu.Juhe.Request
{
    public class JuheOrderCloseRequest : BaseJuheRequest, IBaofuRequest<BaseJuheResponse<JuheOrderCloseResponse>>
    {
        public JuheOrderCloseRequest() : base("order_close")
        {
        }

        /// <summary>
        /// 宝付订单号
        /// </summary>
        public string tradeNo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string outTradeNo { get; set; }
    }
}