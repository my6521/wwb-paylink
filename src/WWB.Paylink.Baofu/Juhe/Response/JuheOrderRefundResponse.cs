namespace WWB.Paylink.Baofu.Juhe.Response
{
    public class JuheOrderRefundResponse
    {
        /// <summary>
        /// 原支付订单宝付交易号
        /// </summary>
        public string originTradeNo { get; set; }

        /// <summary>
        /// 原支付订单商户订单号
        /// </summary>
        public string originOutTradeNo { get; set; }

        /// <summary>
        /// 商户退款订单号
        /// </summary>
        public string outTradeNo { get; set; }

        /// <summary>
        /// 宝付退款交易号
        /// </summary>
        public string tradeNo { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        public int refundAmt { get; set; }

        /// <summary>
        /// 退款总金额
        /// </summary>
        public int totalAmt { get; set; }

        /// <summary>
        /// 业务结果 SUCCESS：业务受理成功，FAIL：业务受理失败
        /// </summary>
        public string resultCode { get; set; }

        /// <summary>
        /// 订单状态 详见附录订单状态
        /// </summary>
        public string refundState { get; set; }

        /// <summary>
        /// 错误代码 当业务结果FAIL时，返回错误代码
        /// </summary>
        public string errCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        public string errMsg { get; set; }

        /// <summary>
        /// 请求方保留域
        /// </summary>
        public string reqReserved { get; set; }
    }
}