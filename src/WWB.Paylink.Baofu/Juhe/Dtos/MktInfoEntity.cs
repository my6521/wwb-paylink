namespace WWB.Paylink.Baofu.Juhe.Dtos
{
    /// <summary>
    /// 营销信息
    /// </summary>
    public class MktInfoEntity
    {
        /// <summary>
        /// 宝付支付分配的商户号
        /// </summary>
        public string mktMerId { get; set; }

        /// <summary>
        /// 营销金额，单位：分，如：1元则传入100
        /// </summary>
        public string mktAmt { get; set; }
    }
}