using System;

namespace WWB.Paylink.JoinPay
{
    public class JoinPayException : Exception
    {
        public JoinPayException()
        {
        }

        public JoinPayException(string messages) : base(messages)
        {
        }

        public JoinPayException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}