namespace WWB.Paylink.BaofPay;

public class BaofPayException : Exception
{
    public BaofPayException()
    {
    }

    public BaofPayException(string messages) : base(messages)
    {
    }

    public BaofPayException(string message, Exception innerException) : base(message, innerException)
    {
    }
}