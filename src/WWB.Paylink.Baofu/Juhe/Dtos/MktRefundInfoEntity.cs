namespace WWB.Paylink.Baofu.Juhe.Dtos
{
    /// <summary>
    /// 营销退款信息
    /// </summary>
    public class MktRefundInfoEntity
    {
        /// <summary>
        /// 商户号
        /// </summary>
        public string mktMerId { get; set; }

        /// <summary>
        /// 营销金额
        /// </summary>
        public int mktAmt { get; set; }
    }
}