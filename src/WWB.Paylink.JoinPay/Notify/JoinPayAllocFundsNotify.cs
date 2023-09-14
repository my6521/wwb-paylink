using System.Collections.Generic;

namespace WWB.Paylink.JoinPay.Notify
{
    /// <summary>
    /// 分账异步通知
    /// </summary>
    public class JoinPayAllocFundsNotify : JoinPayNotify
    {
        /// <summary>
        /// 商户编号
        /// </summary>
        public string r1_MerchantNo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string r2_OrderNo { get; set; }

        /// <summary>
        /// 支付平台生成的流水号。
        /// </summary>
        public string r3_TrxNo { get; set; }

        /// <summary>
        /// 支付金额
        /// </summary>
        public decimal r4_OrderAmount { get; set; }

        /// <summary>
        /// 订单手续费
        /// </summary>
        public decimal r5_Fee { get; set; }

        /// <summary>
        /// 分账信息
        /// </summary>
        public string r6_altInfo { get; set; }

        public string hmac { get; set; }

        public override IDictionary<string, string> GetParameters()
        {
            var parameters = new Dictionary<string, string>
            {
                {"r1_MerchantNo", r1_MerchantNo},
                {"r2_OrderNo", r2_OrderNo},
                {"r3_TrxNo", r3_TrxNo.ToString()},
                {"r4_OrderAmount", $"{r4_OrderAmount}"},
                {"r5_Fee", $"{r5_Fee}"},
                {"r6_altInfo", r6_altInfo},
                {"hmac", hmac},
            };

            return parameters;
        }
    }
}