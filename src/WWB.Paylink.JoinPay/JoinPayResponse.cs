using System.Collections.Generic;

namespace WWB.Paylink.JoinPay
{
    public abstract class JoinPayResponse
    {
        /// <summary>
        /// 原始内容
        /// </summary>
        public string Body { get; set; }

        public abstract IDictionary<string, string> GetParameters();

    }
}