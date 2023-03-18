using System;

namespace WWB.Paylink.BaoFooTransfer
{
    public class BaoFooTransException : Exception
    {
        public BaoFooTransException()
        {
        }

        public BaoFooTransException(string messages) : base(messages)
        {
        }

        public BaoFooTransException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}