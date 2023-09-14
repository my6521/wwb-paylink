using System.Collections.Generic;
using WWB.Paylink.JoinPay.Response;

namespace WWB.Paylink.JoinPay.Request
{
    /// <summary>
    /// 聚合支付
    /// </summary>
    public class JoinPayUnifiedOrderRequest : JoinPayAbstractRequest, IJoinPayRequest<JoinPayUnifiedOrderResponse>
    {
        #region 属性

        /// <summary>
        /// 版本号 必填
        /// </summary>
        public string p0_Version { get; set; } = "2.1";

        /// <summary>
        /// 商户编号 商户在支付平台系统的唯一身份标识。 必填
        /// </summary>
        public string p1_MerchantNo { get; set; }

        /// <summary>
        /// 商户订单号 商户系统提交的唯一订单号 必填
        /// </summary>
        public string p2_OrderNo { get; set; }

        /// <summary>
        /// p3_Amount 单位:元，精确到分，保留两位小数。例如：10.23 。必填
        /// </summary>
        public decimal p3_Amount { get; set; }

        /// <summary>
        /// 交易币种 默认设置为 1（代表人民币）。 必填
        /// </summary>
        public string p4_Cur { get; set; } = "1";

        /// <summary>
        /// 商品名称 必填
        /// </summary>
        public string p5_ProductName { get; set; }

        /// <summary>
        /// 商品描述 对商品信息进行描述
        /// </summary>
        public string p6_ProductDesc { get; set; }

        /// <summary>
        /// 公用回传参数 如果商户请求时传递了该参数，则返回给商户时会原值传回。
        /// </summary>
        public string p7_Mp { get; set; }

        /// <summary>
        /// 商户页面通知地址
        /// </summary>
        public string p8_ReturnUrl { get; set; }

        /// <summary>
        /// 服务器异步通知地址 必填
        /// </summary>
        public string p9_NotifyUrl { get; set; }

        /// <summary>
        /// 交易类型。必填
        /// </summary>
        public string q1_FrpCode { get; set; }

        /// <summary>
        /// 银行商户编码
        /// </summary>
        public string q2_MerchantBankCode { get; set; }

        /// <summary>
        /// 是否展示图片 默认为空,不输出图片；填 1 表示输出图片， 仅交易类型为主扫时可用
        /// </summary>
        public string q4_IsShowPic { get; set; }

        /// <summary>
        /// 微信 Openid
        /// </summary>
        public string q5_OpenId { get; set; }

        /// <summary>
        /// 付款码数字
        /// </summary>
        public string q6_AuthCode { get; set; }

        /// <summary>
        /// APPID
        /// </summary>
        public string q7_AppId { get; set; }

        /// <summary>
        /// 终端设备号
        /// </summary>
        public string q8_TerminalNo { get; set; }

        /// <summary>
        /// 支付宝H5模式
        /// </summary>
        public string q9_TransactionModel { get; set; }

        /// <summary>
        /// 报备商户号 必填
        /// </summary>
        public string qa_TradeMerchantNo { get; set; }

        /// <summary>
        /// 买家的支付宝唯一用户号
        /// </summary>
        public string qb_buyerId { get; set; }

        /// <summary>
        /// 是否分账交易。分账交易传1，不传或传其他值则是非分账交易
        /// </summary>
        public int qc_IsAlt { get; set; }

        /// <summary>
        /// 分账类型
        /// 当qc_IsAlt 取值1 时必传，
        /// 11 表示实时分账
        /// 12 表示延迟分账
        /// 13 表示多次分账
        /// </summary>
        public int? qd_AltType { get; set; }

        /// <summary>
        /// 分账信息。当qc_IsAlt 取值1 且qd_AltType 取值11 时必传。json数组格式
        /// </summary>
        public string qe_AltInfo { get; set; }

        /// <summary>
        /// 分账通知地址。汇聚支付系统主动通知商户网站里指定的http 地址。
        /// </summary>
        public string qf_AltUrl { get; set; }

        /// <summary>
        /// 支付请求的营销金额
        /// </summary>
        public decimal? qg_MarketingAmount { get; set; }
        /// <summary>
        /// 花呗分期数
        /// </summary>
        public string qh_HbFqNum { get; set; }

        /// <summary>
        /// 卖家承担收费比例。目前仅支持传入 0，即用户承担手续费
        /// </summary>
        public string qi_FqSellerPercen { get; set; }

        /// <summary>
        /// 点金计划
        /// </summary>
        public string qj_DJPlan { get; set; }

        /// <summary>
        /// 禁用支付方式
        /// </summary>
        public string qk_DisablePayModel { get; set; }

        /// <summary>
        /// 终端设备IP。必填
        /// </summary>
        public string ql_TerminalIp { get; set; }

        #endregion 属性

        #region IJoinPayRequest


        public string GetRequestUrl(bool debug)
        {
            return "https://www.joinpay.com/trade/uniPayApi.action";
        }

        public override string GetContentType()
        {
            return Paylink.Utility.HttpContentType.PostFormUrlencoded;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new Dictionary<string, string>
            {
                {"p0_Version", p0_Version},
                {"p1_MerchantNo", p1_MerchantNo},
                {"p2_OrderNo", p2_OrderNo},
                {"p3_Amount", $"{p3_Amount}"},
                {"p4_Cur", $"{p4_Cur}"},
                {"p5_ProductName", p5_ProductName},
                {"p6_ProductDesc", p6_ProductDesc},
                {"p7_Mp", p7_Mp},
                {"p8_ReturnUrl", p8_ReturnUrl},
                {"p9_NotifyUrl", p9_NotifyUrl},
                {"q1_FrpCode", q1_FrpCode},
                {"q2_MerchantBankCode", q2_MerchantBankCode},
                {"q4_IsShowPic", $"{q4_IsShowPic}"},
                {"q5_OpenId", q5_OpenId},
                {"q6_AuthCode", q6_AuthCode},
                {"q7_AppId", q7_AppId},
                {"q8_TerminalNo", q8_TerminalNo},
                {"q9_TransactionModel", q9_TransactionModel},
                {"qa_TradeMerchantNo", qa_TradeMerchantNo},
                {"qb_buyerId", qb_buyerId},
                {"qc_IsAlt", $"{qc_IsAlt}"},
                {"qd_AltType", $"{qd_AltType}"},
                {"qe_AltInfo", qe_AltInfo},
                {"qf_AltUrl", qf_AltUrl},
                {"qg_MarketingAmount", $"{qg_MarketingAmount}"},
                {"qh_HbFqNum", qh_HbFqNum},
                {"qi_FqSellerPercen", qi_FqSellerPercen},
                {"qj_DJPlan", qj_DJPlan},
                {"qk_DisablePayModel", qk_DisablePayModel},
                {"ql_TerminalIp", ql_TerminalIp},
            };
            return parameters;
        }


        #endregion IJoinPayRequest
    }
}