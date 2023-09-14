using System.Collections.Generic;

namespace WWB.Paylink.JoinPay
{
    public abstract class JoinPayNotify
    {
        public string Body { get; set; }

        public abstract IDictionary<string, string> GetParameters();

    }
}