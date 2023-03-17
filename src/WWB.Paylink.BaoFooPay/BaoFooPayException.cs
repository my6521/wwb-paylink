namespace WWB.Paylink.BaoFooPay
{
    public class BaoFooPayException : Exception
    {
        public BaoFooPayException()
        {
        }

        public BaoFooPayException(string messages) : base(messages)
        {
        }

        public BaoFooPayException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}