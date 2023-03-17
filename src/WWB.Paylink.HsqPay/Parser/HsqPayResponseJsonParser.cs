using Newtonsoft.Json.Linq;

namespace WWB.Paylink.HsqPay.Parser;

public class HsqPayResponseJsonParser<T> where T : HsqPayResponse
{
    public T Parse(string body, int statusCode)
    {
        T result = null;
        try
        {
            if (body.StartsWith("{") && body.EndsWith("}"))
            {
                var json = JObject.Parse(body);
                if (body.Contains("status"))
                {
                    result = Activator.CreateInstance<T>();
                    result.Success = "false";
                    result.ErrorMsg = json["message"].ToString();
                }
                else
                {
                    result = JsonConvert.DeserializeObject<T>(body);
                }
            }
        }
        catch
        {
        }

        if (result == null)
        {
            result = Activator.CreateInstance<T>();
            result.Success = "false";
            result.ErrorMsg = body;
        }

        result.Body = body;
        result.Execute();
        return result;
    }
}