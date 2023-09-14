using System.Collections.Generic;

namespace WWB.Paylink.JoinPay.Response
{
    public class JoinPaySinglePayResponse : JoinPayResponse
    {
        public string statusCode { get; set; }
        public string message { get; set; }
        public JoinPaySinglePayResponseData data { get; set; }

        public override IDictionary<string, string> GetParameters()
        {
            var parameters = new Dictionary<string, string>
            {
                { "statusCode", statusCode },
                { "message", message },
                { "errorCode", $"{data.errorCode}" },
                { "errorDesc", data.errorDesc },
                { "userNo", data.userNo },
                { "merchantOrderNo", data.merchantOrderNo },
                { "hmac", data.hmac },
            };

            return parameters;
        }


        public class JoinPaySinglePayResponseData
        {
            public string errorCode { get; set; }
            public string errorDesc { get; set; }
            public string userNo { get; set; }
            public string merchantOrderNo { get; set; }
            public string hmac { get; set; }
        }
    }
}