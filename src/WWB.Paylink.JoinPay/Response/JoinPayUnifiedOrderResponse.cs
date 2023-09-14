using System.Collections.Generic;

namespace WWB.Paylink.JoinPay.Response
{
    public class JoinPayUnifiedOrderResponse : JoinPayResponse
    {
        #region 属性

        /// <summary>
        /// 版本号
        /// </summary>
        public string r0_Version { get; set; }

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
        /// 币种 默认设置为1（代表人民币）。
        /// </summary>
        public int r4_Cur { get; set; }

        /// <summary>
        /// 公用回传参数
        /// </summary>
        public string r5_Mp { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        public string r6_FrpCode { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        public string r7_TrxNo { get; set; }

        /// <summary>
        /// 银行商户编码
        /// </summary>
        public string r8_MerchantBankCode { get; set; }

        /// <summary>
        /// 子商户号 当q3_SubMerchantNo不为空时
        /// </summary>
        public string r9_SubMerchantNo { get; set; }

        /// <summary>
        /// 响应码。返回 100 时表示成功，响应码描述为空。
        /// </summary>
        public string ra_Code { get; set; }

        /// <summary>
        /// 响应码描述
        /// </summary>
        public string rb_CodeMsg { get; set; }

        /// <summary>
        /// 结果
        /// </summary>

        public string rc_Result { get; set; }

        /// <summary>
        /// 二维码图片码
        /// </summary>
        public string rd_Pic { get; set; }

        public string hmac { get; set; }

        #endregion 属性

        public override IDictionary<string, string> GetParameters()
        {
            var parameters = new Dictionary<string, string>
            {
                { "p0_Version", r0_Version },
                { "r1_MerchantNo", r1_MerchantNo },
                { "r2_OrderNo", r2_OrderNo },
                { "r3_Amount", $"{r3_Amount}" },
                { "r4_Cur", $"{r4_Cur}" },
                { "r5_Mp", r5_Mp },
                { "r6_FrpCode", r6_FrpCode },
                { "r7_TrxNo", r7_TrxNo },
                { "r8_MerchantBankCode", r8_MerchantBankCode },
                { "r9_SubMerchantNo", r9_SubMerchantNo },
                { "ra_Code", ra_Code },
                { "rb_CodeMsg", rb_CodeMsg },
                { "rc_Result", rc_Result },
                { "rd_Pic", rd_Pic },
                { "hmac", hmac },
            };

            return parameters;
        }

    }
}