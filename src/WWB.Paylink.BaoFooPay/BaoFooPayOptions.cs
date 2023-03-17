namespace WWB.Paylink.BaoFooPay
{
    public class BaoFooPayOptions
    {
        /// <summary>
        /// 商户号
        /// </summary>
        public string MerchantNo { get; set; }

        /// <summary>
        /// 签名混淆KEY
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 商户私钥。可为 证书文件路径、证书文件的Base64编码。
        /// </summary>
        public string PfxCertificate { get; set; }

        /// <summary>
        /// 商户私钥密码
        /// </summary>
        public string Password { get; set; }

        public string CerCertificate { get; set; }

        public bool Debug { get; set; }
    }
}