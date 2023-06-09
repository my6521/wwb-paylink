﻿namespace WWB.Paylink.BaoFooPay
{
    public class BaoFooPayOptions
    {
        /// <summary>
        /// 应用Id，微信支付需要
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        public string MerchantNo { get; set; }

        /// <summary>
        /// 签名混淆KEY
        /// </summary>
        public string Key { get; set; }

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
    }
}