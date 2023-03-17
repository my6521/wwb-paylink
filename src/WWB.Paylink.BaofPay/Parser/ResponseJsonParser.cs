namespace WWB.Paylink.BaofPay.Parser;

public class ResponseJsonParser<T> where T : BaofPayResponse
{
    public T Parse(string body)
    {
        T result = null;
        try
        {
            if (body.StartsWith("{") && body.EndsWith("}"))
            {
                result = JsonConvert.DeserializeObject<T>(body);
            }
        }
        catch
        {
        }

        if (result == null)
        {
            result = Activator.CreateInstance<T>();
        }

        result.Body = body;
        result.Execute();

        return result;
    }
}