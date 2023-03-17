using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace WWB.Paylink.Utility
{
    public static class HttpClientExtensions
    {
        public static async Task<(string body, bool isSuccessStatusCode)> PostAsync(this HttpClient client, string url, string contentType, IDictionary<string, string> textParams)
        {
            string content;

            if (contentType == HttpContentType.PostJson)
            {
                content = BuildContent(textParams);
            }
            else if (contentType == HttpContentType.PostFormUrlencoded)
            {
                content = BuildQuery(textParams);
            }
            else
            {
                throw new Exception($"{contentType} is not Support");
            }

            using (var reqContent = new StringContent(content, Encoding.UTF8, contentType))
            {
                using (var resp = await client.PostAsync(url, reqContent))
                {
                    using (var respContent = resp.Content)
                    {
                        var isSuccessStatusCode = resp.IsSuccessStatusCode;
                        var body = await respContent.ReadAsStringAsync();
                        return (body, isSuccessStatusCode);
                    }
                }
            }
        }

        /// <summary>
        /// 组装XML格式请求参数。
        /// </summary>
        /// <param name="dictionary">Key-Value形式请求参数字典</param>
        /// <returns>XML格式的请求数据</returns>
        private static string BuildContent(IDictionary<string, string> dictionary)
        {
            if (dictionary == null || dictionary.Count == 0)
            {
                throw new ArgumentNullException(nameof(dictionary));
            }

            var parameters = dictionary
                .Where(item => !string.IsNullOrEmpty(item.Value))
                .ToDictionary(p => p.Key, p => p.Value);

            return JsonConvert.SerializeObject(parameters, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        /// <summary>
        /// 组装普通文本请求参数。
        /// </summary>
        /// <param name="dictionary">Key-Value形式请求参数字典</param>
        /// <returns>URL编码后的请求数据</returns>
        private static string BuildQuery(IDictionary<string, string> dictionary)
        {
            if (dictionary == null || dictionary.Count == 0)
            {
                throw new ArgumentNullException(nameof(dictionary));
            }

            var sb = new StringBuilder();
            foreach (var iter in dictionary)
            {
                if (!string.IsNullOrEmpty(iter.Value))
                {
                    sb.Append(iter.Key + "=" + WebUtility.UrlEncode(iter.Value) + "&");
                }
            }

            return sb.ToString()[0..^1];
        }
    }
}