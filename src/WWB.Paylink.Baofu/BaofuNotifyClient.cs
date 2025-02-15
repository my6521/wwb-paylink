﻿using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WWB.Paylink.Baofu.Parser;

namespace WWB.Paylink.Baofu
{
    public class BaofuNotifyClient : IBaofuNotifyClient
    {
        public async Task<T> ExecuteAsync<T>(HttpRequest request, BaofuOptions options) where T : BaseNotify
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            string content = string.Empty;
            if (HttpMethods.IsPost(request.Method))
            {
                using (var reader = new StreamReader(request.Body, Encoding.UTF8))
                {
                    content = await reader.ReadToEndAsync();
                }
            }
            else if (HttpMethods.IsGet(request.Method))
            {
                content = request.QueryString.Value;
            }

            if (!string.IsNullOrWhiteSpace(content))
            {
                var parsed = HttpUtility.ParseQueryString(HttpUtility.UrlDecode(content));
                var json = JsonConvert.SerializeObject(ToDictionary(parsed));

                return await ExecuteAsync<T>(json, options);
            }

            throw new BaofuException($"{request.Method} is not Support!");
        }

        public Task<T> ExecuteAsync<T>(string body, BaofuOptions options) where T : BaseNotify
        {
            if (string.IsNullOrEmpty(body))
            {
                throw new ArgumentNullException(nameof(body));
            }

            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            var parser = new NotifyJsonParser<T>();

            //反序列化
            var notify = parser.Parse(body, options);

            return Task.FromResult(notify);
        }

        private IDictionary<string, string> ToDictionary(NameValueCollection source)
        {
            return source.AllKeys.ToDictionary(k => k, k => source[k]);
        }
    }
}