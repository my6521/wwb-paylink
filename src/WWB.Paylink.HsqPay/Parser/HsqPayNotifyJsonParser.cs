namespace WWB.Paylink.HsqPay.Parser;

public class HsqPayNotifyJsonParser<T> where T : HsqPayNotify
{
    public T Parse(string body)
    {
        T result = JsonConvert.DeserializeObject<T>(body);

        result.Body = body;
        result.Execute();
        return result;
    }
}