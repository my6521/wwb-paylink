namespace WWB.Paylink.BaoFooTransfer.Constants
{
    public static class OrderState
    {
        /// <summary>
        /// 转账失败
        /// </summary>
        public const int Fail = -1;

        /// <summary>
        /// 转账中
        /// </summary>
        public const int Processing = 0;

        /// <summary>
        /// 成功
        /// </summary>
        public const int Success = 1;

        /// <summary>
        /// 退款
        /// </summary>
        public const int Refund = 2;
    }
}