namespace WWB.Paylink.BaoFooTransfer.Domain.Response
{
    public class QueryBalanceRespData
    {
        /// <summary>
        /// 返回码 1成功 2处理中 0失败
        /// </summary>
        public int retCode { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        public string errorCode { get; set; }

        /// <summary>
        /// 错误原因
        /// </summary>
        public string errorMsg { get; set; }

        /// <summary>
        /// 账户类型
        /// </summary>
        public string accountType { get; set; }

        /// <summary>
        /// 余额 单位元，最多2位小数
        /// </summary>
        public decimal balance { get; set; }
    }
}