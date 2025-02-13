namespace WWB.Paylink.Baofu.Juhe.Dtos
{
    /// <summary>
    /// 分账退款信息
    /// </summary>
    public class SharingRefundInfoEntity
    {
        /// <summary>
        /// 商户号
        /// </summary>
        public string sharingMerId { get; set; }

        /// <summary>
        /// 分账金额
        /// </summary>
        public int sharingAmt { get; set; }
    }
}