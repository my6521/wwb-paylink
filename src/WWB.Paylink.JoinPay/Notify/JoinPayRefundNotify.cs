using System.Collections.Generic;

namespace WWB.Paylink.JoinPay.Notify
{
    /// <summary>
    /// 退款通知
    /// </summary>
    public class JoinPayRefundNotify : JoinPayNotify
    {
        #region 属性

        /// <summary>
        /// 商户编号
        /// </summary>
        public string r1_MerchantNo { get; set; }

        /// <summary>
        /// 原支付商户订单号
        /// </summary>
        public string r2_OrderNo { get; set; }

        /// <summary>
        /// 商户退款订单号
        /// </summary>
        public string r3_RefundOrderNo { get; set; }

        /// <summary>
        /// 退款金额 单位:元，精确到分，保留两位小数。例如：10.23。返回实际退款的金额
        /// </summary>
        public string r4_RefundAmount_str { get; set; }

        /// <summary>
        /// 汇聚系统生成的系统退款流水号
        /// </summary>
        public string r5_RefundTrxNo { get; set; }

        /// <summary>
        /// 退款完成时间 yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string r6_RefundCompleteTime { get; set; }

        /// <summary>
        /// 退款渠道
        /// </summary>
        public string r7_RefundWay { get; set; }

        /// <summary>
        /// 退款入账账户
        /// </summary>
        public string r8_ReceiveAccountNo { get; set; }

        /// <summary>
        /// 退款状态 100:成功 101:失败
        /// </summary>
        public string ra_Status { get; set; }

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
            var parameters = new Dictionary<string, string> {
                { "r1_MerchantNo", r1_MerchantNo },
                { "r2_OrderNo", r2_OrderNo },
                { "r3_RefundOrderNo", r3_RefundOrderNo },
                { "r4_RefundAmount_str", r4_RefundAmount_str },
                { "r5_RefundTrxNo", r5_RefundTrxNo },
                { "r6_RefundCompleteTime", r6_RefundCompleteTime },
                { "r7_RefundWay", r7_RefundWay },
                { "r8_ReceiveAccountNo", r8_ReceiveAccountNo },
                { "ra_Status", ra_Status },
                { "rb_Code", rb_Code },
                { "rc_CodeMsg", rc_CodeMsg },
                { "hmac", hmac },
            };

            return parameters;
        }
    }
}