using System.Collections.Generic;

namespace WWB.Paylink.JoinPay.Response
{
    public class JoinPayQueryOrderResponse : JoinPayResponse
    {
        public string r1_MerchantNo { get; set; }
        public string r2_OrderNo { get; set; }
        public string r3_Amount { get; set; }
        public string r4_ProductName { get; set; }
        public string r5_TrxNo { get; set; }
        public string r6_BankTrxNo { get; set; }
        public string ra_Status { get; set; }
        public string rb_Code { get; set; }
        public string rc_CodeMsg { get; set; }
        public string rd_OpenId { get; set; }
        public string re_DiscountAmount { get; set; }
        public string rf_PayTime { get; set; }
        public string rh_cardType { get; set; }
        public string hmac { get; set; }

        public override IDictionary<string, string> GetParameters()
        {
            var parameters = new Dictionary<string, string>
            {
                { "r1_MerchantNo", r1_MerchantNo },
                { "r2_OrderNo", r2_OrderNo },
                { "r3_Amount", $"{r3_Amount}" },
                { "r4_ProductName", r4_ProductName },
                { "r5_TrxNo", r5_TrxNo },
                { "r6_BankTrxNo", r6_BankTrxNo },
                { "ra_Status", ra_Status },
                { "rb_Code", rb_Code },
                { "rc_CodeMsg", rc_CodeMsg },
                { "rd_OpenId", rd_OpenId },
                { "re_DiscountAmount", re_DiscountAmount },
                { "rf_PayTime", rf_PayTime },
                { "rh_cardType", rh_cardType },
                { "hmac", hmac },
            };

            return parameters;
        }

    }
}