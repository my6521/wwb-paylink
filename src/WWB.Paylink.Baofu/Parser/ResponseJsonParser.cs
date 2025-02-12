﻿using Newtonsoft.Json;
using System;

namespace WWB.Paylink.Baofu.Parser
{
    public class ResponseJsonParser<T> where T : BaseResponse
    {
        public T Parse(string body, BaofuOptions options)
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
            result.PrimaryHandler(options);

            return result;
        }
    }
}