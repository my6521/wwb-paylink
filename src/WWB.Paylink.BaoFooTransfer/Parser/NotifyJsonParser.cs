namespace WWB.Paylink.BaoFooTransfer.Parser;

public class NotifyJsonParser<T> where T : BaofPayNotify
{
    public T Parse(string body, BaofPayOptions options)
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
        result.Execute(options);

        return result;
    }
}