using Newtonsoft.Json;

namespace WWB.Paylink.JoinPay.Parser
{
    public class JoinPayResponseJsonParser<T> where T : JoinPayResponse
    {
        public T Parse(string body)
        {
            T result = JsonConvert.DeserializeObject<T>(body);

            result.Body = body;

            return result;
        }
    }
}