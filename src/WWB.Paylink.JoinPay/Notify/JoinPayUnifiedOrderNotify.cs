using System.Collections.Generic;

namespace WWB.Paylink.JoinPay.Notify
{
    /// <summary>
    /// 支付异步通知
    /// </summary>
    public class JoinPayUnifiedOrderNotify : JoinPayNotify
    {
        #region 属性

        /// <summary>
        /// 商户编号
        /// </summary>
        public string r1_MerchantNo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string r2_OrderNo { get; set; }

        /// <summary>
        /// 支付金额
        /// </summary>
        public decimal r3_Amount { get; set; }

        /// <summary>
        /// 交易币种
        /// </summary>
        public string r4_Cur { get; set; }

        /// <summary>
        /// 公用回传参数
        /// </summary>
        public string r5_Mp { get; set; }

        /// <summary>
        /// 支付状态 100：支付成功；101：支付失败
        /// </summary>
        public string r6_Status { get; set; }

        /// <summary>
        /// 支付平台生成的流水号。
        /// </summary>
        public string r7_TrxNo { get; set; }

        /// <summary>
        /// 支付平台生成的提交给银行的订单号。
        /// </summary>
        public string r8_BankOrderNo { get; set; }

        /// <summary>
        /// 银行返回的流水号
        /// </summary>
        public string r9_BankTrxNo { get; set; }

        /// <summary>
        /// 支付时间 格式：yyyy-MM-dd HH:mm:ss  HH 代表 24 小时制）。
        /// </summary>
        public string ra_PayTime { get; set; }

        /// <summary>
        /// 交易结果通知时间 格式：yyyy-MM-dd HH:mm:ss  HH 代表 24 小时制）。
        /// </summary>
        public string rb_DealTime { get; set; }

        /// <summary>
        /// 银行编码
        /// </summary>
        public string rc_BankCode { get; set; }

        /// <summary>
        /// 用户标识
        /// </summary>
        public string rd_OpenId { get; set; }

        /// <summary>
        /// 平台优惠金额，单位:元，精确到分，保留两位小数。例如：10.23
        /// </summary>
        public decimal? re_DiscountAmount { get; set; }

        /// <summary>
        /// 卡类型
        /// </summary>
        public string rh_cardType { get; set; }

        public string hmac { get; set; }

        #endregion 属性

        public override IDictionary<string, string> GetParameters()
        {
            var parameters = new Dictionary<string, string>
            {
                {"r1_MerchantNo", r1_MerchantNo},
                {"r2_OrderNo", r2_OrderNo},
                {"r3_Amount", r3_Amount.ToString()},
                {"r4_Cur", r4_Cur},
                {"r5_Mp", r5_Mp},
                {"r6_Status", $"{r6_Status}"},
                {"r7_TrxNo", r7_TrxNo},
                {"r8_BankOrderNo", r8_BankOrderNo},
                {"r9_BankTrxNo", r9_BankTrxNo},
                {"ra_PayTime", ra_PayTime.ToString()},
                {"rb_DealTime", rb_DealTime.ToString()},
                {"rc_BankCode", rc_BankCode},
                {"rd_OpenId", rd_OpenId},
                {"re_DiscountAmount", re_DiscountAmount.ToString()},
                {"rh_cardType", rh_cardType},
                {"hmac", hmac},
            };

            return parameters;
        }
    }
}