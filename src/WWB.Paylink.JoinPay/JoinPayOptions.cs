namespace WWB.Paylink.JoinPay
{
    public class JoinPayOptions
    {
        /// <summary>
        /// 商户API密钥
        /// </summary>
        public string APIKey { get; set; }

        /// <summary>
        /// 商户编号
        /// </summary>
        public string MerchantNo { get; set; }

        /// <summary>
        /// 报备商户编号
        /// </summary>
        public string TradeMerchantNo { get; set; }

        /// <summary>
        /// AppId
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Debug { get; set; }

    }
}