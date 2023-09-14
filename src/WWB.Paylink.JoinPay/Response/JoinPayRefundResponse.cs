using System.Collections.Generic;

namespace WWB.Paylink.JoinPay.Response
{
    public class JoinPayRefundResponse : JoinPayResponse
    {
        #region 属性

        /// <summary>
        /// 商户编号
        /// </summary>
        public string r1_MerchantNo { get; set; }

        /// <summary>
        /// 商户原支付订单号
        /// </summary>
        public string r2_OrderNo { get; set; }

        /// <summary>
        /// 商户退款订单号
        /// </summary>
        public string r3_RefundOrderNo { get; set; }

        /// <summary>
        /// 退款金额 单位:元，精确到分，保留两位小数。例如：10.23。
        /// </summary>
        public decimal r4_RefundAmount { get; set; }

        /// <summary>
        /// 商户退款流水号
        /// </summary>
        public string r5_RefundTrxNo { get; set; }

        /// <summary>
        /// 退款申请状态 100:成功， 101:失败 。
        /// </summary>
        public int ra_Status { get; set; }

        /// <summary>
        /// 响应码
        /// </summary>
        public string rb_Code { get; set; }

        /// <summary>
        /// 响应码描述
        /// </summary>
        public string rc_CodeMsg { get; set; }

        public string hmac { get; set; }

        #endregion 属性

        public override IDictionary<string, string> GetParameters()
        {
            var parameters = new Dictionary<string, string>
            {
                { "r1_MerchantNo", r1_MerchantNo },
                { "r2_OrderNo", r2_OrderNo },
                { "r3_RefundOrderNo", r3_RefundOrderNo },
                { "r4_RefundAmount", $"{r4_RefundAmount}" },
                { "r5_RefundTrxNo", r5_RefundTrxNo },
                { "ra_Status", $"{ra_Status}" },
                { "rb_Code", rb_Code },
                { "rc_CodeMsg", rc_CodeMsg },
                { "hmac", hmac },
            };

            return parameters;
        }

    }
}