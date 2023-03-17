namespace WWB.Paylink.HsqPay;

public class HsqPayException : Exception
{
    public HsqPayException()
    {
    }

    public HsqPayException(string messages) : base(messages)
    {
    }

    public HsqPayException(string message, Exception innerException) : base(message, innerException)
    {
    }
}