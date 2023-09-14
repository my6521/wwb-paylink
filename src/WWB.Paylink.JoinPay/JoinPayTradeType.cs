namespace WWB.Paylink.JoinPay
{
    /// <summary>
    /// 交易类型
    /// </summary>
    public static class JoinPayTradeType
    {
        /// <summary>
        /// 微信扫码（主扫）
        /// </summary>
        public const string WEIXIN_NATIVE = "WEIXIN_NATIVE";

        /// <summary>
        /// 微信刷卡（被扫）
        /// </summary>
        public const string WEIXIN_CARD = "WEIXIN_CARD";

        /// <summary>
        /// 微信 APP+支付
        /// </summary>
        public const string WEIXIN_APP3 = "WEIXIN_APP3";

        /// <summary>
        /// 微信 H5 支付
        /// </summary>
        public const string WEIXIN_H5_PLUS = "WEIXIN_H5_PLUS";

        /// <summary>
        /// 微信公众号支付
        /// </summary>
        public const string WEIXIN_GZH = "WEIXIN_GZH";

        /// <summary>
        /// 微信小程序支付
        /// </summary>
        public const string WEIXIN_XCX = "WEIXIN_XCX";

        /// <summary>
        /// 支付宝扫码(主扫)
        /// </summary>
        public const string ALIPAY_NATIVE = "ALIPAY_NATIVE";

        /// <summary>
        /// 支付宝刷卡（被扫）
        /// </summary>
        public const string ALIPAY_CARD = "ALIPAY_CARD";

        /// <summary>
        /// 支付宝H5
        /// </summary>
        public const string ALIPAY_H5 = "ALIPAY_H5";

        /// <summary>
        ///  支付宝服务窗
        /// </summary>
        public const string ALIPAY_FWC = "ALIPAY_FWC";

        /// <summary>
        /// 支付宝收银台
        /// </summary>
        public const string ALIPAY_SYT = "ALIPAY_SYT";

        /// <summary>
        /// 京东扫码（主扫）
        /// </summary>
        public const string JD_NATIVE = "JD_NATIVE";

        /// <summary>
        /// 京东刷卡（被扫）
        /// </summary>
        public const string JD_CARD = "JD_CARD";

        /// <summary>
        /// 京东 APP 支付
        /// </summary>
        public const string JD_APP = "JD_APP";

        /// <summary>
        /// 京东 H5 支付
        /// </summary>
        public const string JD_H5 = "JD_H5";

        public const string QQ_NATIVE = "QQ_NATIVE";
        public const string QQ_CARD = "QQ_CARD";
        public const string QQ_APP = "QQ_APP";
        public const string QQ_H5 = "QQ_H5";
        public const string QQ_GZH = "QQ_GZH";
        public const string UNIONPAY_NATIVE = "UNIONPAY_NATIVE";
        public const string UNIONPAY_CARD = "UNIONPAY_CARD";
        public const string UNIONPAY_APP = "UNIONPAY_APP";
        public const string UNIONPAY_H5 = "UNIONPAY_H5";
        public const string UNIONPAY_SYT = "UNIONPAY_SYT";
        public const string BAIDU_NATIVE = "BAIDU_NATIVE";
        public const string SUNING_NATIVE = "SUNING_NATIVE";
    }
}