using System;
using Newtonsoft.Json;

namespace WWB.Paylink.BaoFooTransfer.Parser
{
    public class ResponseJsonParser<T> where T : BaseResponse
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

            result.Raw = body;
            result.Execute();

            return result;
        }
    }
}