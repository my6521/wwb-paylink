using Newtonsoft.Json;

namespace WWB.Paylink.JoinPay.Parser
{
    public class JoinPayNotifyJsonParser<T> where T : JoinPayNotify
    {
        public T Parse(string body)
        {
            T result = JsonConvert.DeserializeObject<T>(body);

            result.Body = body;

            return result;
        }
    }
}