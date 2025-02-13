namespace WWB.Paylink.Baofu.Juhe
{
    /// <summary>
    /// 支付返回状态
    /// </summary>
    public class UnifiedOrderState
    {
        /// <summary>
        /// 交易成功，支付成功的订单再次发起支付依然返回支付成功，商户侧需做幂等处理
        /// </summary>
        public const string SUCCESS = "SUCCESS";

        /// <summary>
        /// 已关闭 通常存在3种情况会关闭订单 1：商户侧发起的订单关闭 2：超出订单有效期还未支付成功的订单，系统自动关闭 3：被风控的订单 已关闭的订单不能再次发起支付
        /// </summary>
        public const string CLOSED = "CLOSED";

        /// <summary>
        /// 下单成功，等待用户支付中
        /// </summary>
        public const string WAIT_PAYING = "WAIT_PAYING";

        /// <summary>
        /// 支付失败，同一笔订单号在有效期内可再次发起支付
        /// </summary>
        public const string PAY_ERROR = "PAY_ERROR";

        /// <summary>
        /// 支付订单已退款
        /// </summary>
        public const string REFUND = "REFUND";

        /// <summary>
        /// 支付异常，返回此状态的支付订单，请稍后发起查询。
        /// </summary>
        public const string ABNORMAL = "ABNORMAL";
    }
}