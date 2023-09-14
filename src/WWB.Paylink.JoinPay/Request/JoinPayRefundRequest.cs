using System.Collections.Generic;
using WWB.Paylink.JoinPay.Response;

namespace WWB.Paylink.JoinPay.Request
{
    /// <summary>
    /// 退款
    /// </summary>
    public class JoinPayRefundRequest : JoinPayAbstractRequest, IJoinPayRequest<JoinPayRefundResponse>
    {
        #region 属性

        /// <summary>
        /// 商户编号
        /// </summary>
        public string p1_MerchantNo { get; set; }

        /// <summary>
        /// 商户原支付订单号

        /// </summary>
        public string p2_OrderNo { get; set; }

        /// <summary>
        /// 商户退款订单号
        /// </summary>
        public string p3_RefundOrderNo { get; set; }

        /// <summary>
        /// 退款金额 单位:元，精确到分，保留两位小数。例如：10.23。
        /// </summary>
        public decimal p4_RefundAmount { get; set; }

        /// <summary>
        /// 退款原因描述
        /// </summary>
        public string p5_RefundReason { get; set; }

        /// <summary>
        /// 服务器异步通知地址
        /// </summary>
        public string p6_NotifyUrl { get; set; }

        /// <summary>
        /// 接口版本号
        /// </summary>
        public string q1_version { get; set; } = "2.1";

        #endregion 属性

        #region IJoinPayRequest

        public string GetRequestUrl(bool debug)
        {
            return "https://www.joinpay.com/trade/queryOrder.action";
        }

        public override string GetContentType()
        {
            return Paylink.Utility.HttpContentType.PostFormUrlencoded;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new Dictionary<string, string>
            {
                {"p1_MerchantNo", p1_MerchantNo},
                {"p2_OrderNo", p2_OrderNo},
                {"p3_RefundOrderNo", p3_RefundOrderNo},
                {"p4_RefundAmount", $"{p4_RefundAmount}"},
                {"p5_RefundReason", p5_RefundReason},
                {"p6_NotifyUrl", p6_NotifyUrl},
                {"q1_version", q1_version},
            };
            return parameters;
        }



        #endregion IJoinPayRequest
    }
}