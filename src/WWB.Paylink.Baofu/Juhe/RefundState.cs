namespace WWB.Paylink.Baofu.Juhe
{
    /// <summary>
    /// 退款返回状态
    /// </summary>
    public class RefundState
    {
        /// <summary>
        /// 退款成功
        /// </summary>
        public const string SUCCESS = "SUCCESS";

        /// <summary>
        /// 退款受理成功
        /// </summary>
        public const string REFUND = "REFUND";

        /// <summary>
        /// 退款失败
        /// </summary>
        public const string REFUND_ERROR = "REFUND_ERROR";

        /// <summary>
        /// 退款异常，返回此状态的退款订单，请稍后发起查询。
        /// </summary>
        public const string ABNORMAL = "ABNORMAL";
    }
}