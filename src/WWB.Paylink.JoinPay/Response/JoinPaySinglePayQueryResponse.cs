using System.Collections.Generic;

namespace WWB.Paylink.JoinPay.Response
{
    public class JoinPaySinglePayQueryResponse : JoinPayResponse
    {
        public string statusCode { get; set; }
        public string message { get; set; }
        public JoinPaySinglePayQueryResponseData data { get; set; }

        public override IDictionary<string, string> GetParameters()
        {
            var parameters = new Dictionary<string, string>
            {
                { "statusCode", statusCode },
                { "message", message },
                { "status", $"{data.status}" },
                { "errorCode", $"{data.errorCode}" },
                { "errorDesc", data.errorDesc },
                { "userNo", data.userNo },
                { "tradeMerchantNo", data.tradeMerchantNo },
                { "merchantOrderNo", data.merchantOrderNo },
                { "platformSerialNo", data.platformSerialNo },
                { "receiverAccountNoEnc", data.receiverAccountNoEnc },
                { "receiverNameEnc", data.receiverNameEnc },
                { "paidAmount", $"{data.paidAmount}" },
                { "fee", $"{data.fee}" },
                { "hmac", data.hmac },
            };

            return parameters;
        }

        public class JoinPaySinglePayQueryResponseData
        {
            public string status { get; set; }
            public string errorCode { get; set; }
            public string errorDesc { get; set; }
            public string userNo { get; set; }
            public string tradeMerchantNo { get; set; }
            public string merchantOrderNo { get; set; }
            public string platformSerialNo { get; set; }
            public string receiverAccountNoEnc { get; set; }
            public string receiverNameEnc { get; set; }
            public decimal paidAmount { get; set; }
            public decimal fee { get; set; }
            public string hmac { get; set; }
        }
    }
}