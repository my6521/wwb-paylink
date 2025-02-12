namespace WWB.Paylink.Baofu
{
    public class BaofuOptions
    {
        /// <summary>
        /// 商户号
        /// </summary>
        public string MerchantNo { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        public string TerminalId { get; set; }

        /// <summary>
        /// 商户私钥证书路径。
        /// </summary>
        public string PfxCertificate { get; set; }

        /// <summary>
        /// 商户证书密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 平台公钥证书路径
        /// </summary>
        public string CerCertificate { get; set; }

        /// <summary>
        /// 是否测试环境
        /// </summary>
        public bool Debug { get; set; }

        /// <summary>
        /// 宝付支付分配的商户号
        /// </summary>
        public string PayMerId { get; set; }

        /// <summary>
        /// 宝付支付分配的终端号
        /// </summary>
        public string PayTerId { get; set; }
    }
}