using System;

namespace WWB.Paylink.Baofu
{
    public class BaofuException : Exception
    {
        public BaofuException()
        {
        }

        public BaofuException(string messages) : base(messages)
        {
        }

        public BaofuException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}