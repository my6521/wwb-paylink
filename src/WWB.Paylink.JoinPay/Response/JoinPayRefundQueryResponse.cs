using System.Collections.Generic;

namespace WWB.Paylink.JoinPay.Response
{
    public class JoinPayRefundQueryResponse : JoinPayResponse
    {
        public string r1_MerchantNo { get; set; }
        public string r2_RefundOrderNo { get; set; }
        public string r3_RefundAmount { get; set; }
        public string r4_RefundTrxNo { get; set; }
        public string r5_RefundCompleteTime { get; set; }
        public string r8_RefundWay { get; set; }
        public string r9_ReceiveAccountNo { get; set; }
        public string ra_Status { get; set; }
        public string rb_Code { get; set; }
        public string rc_CodeMsg { get; set; }
        public string hmac { get; set; }

        public override IDictionary<string, string> GetParameters()
        {
            var parameters = new Dictionary<string, string>
            {
                { "r1_MerchantNo", r1_MerchantNo },
                { "r2_RefundOrderNo", r2_RefundOrderNo },
                { "r3_RefundAmount", r3_RefundAmount },
                { "r4_RefundTrxNo", r4_RefundTrxNo },
                { "r5_RefundCompleteTime", r5_RefundCompleteTime },
                { "r8_RefundWay", r8_RefundWay },
                { "r9_ReceiveAccountNo", r9_ReceiveAccountNo },
                { "ra_Status", ra_Status },
                { "rb_Code", rb_Code },
                { "rc_CodeMsg", rc_CodeMsg },
                { "hmac", hmac },
            };

            return parameters;
        }

    }
}