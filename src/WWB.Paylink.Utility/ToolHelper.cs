using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WWB.Paylink.Utility
{
    public static class ToolHelper
    {
        public static string GetSignContent(IDictionary<string, string> dictionary, string key, params string[] excludeKeys)
        {
            var sb = new StringBuilder();
            foreach (var iter in dictionary)
            {
                if (excludeKeys != null && excludeKeys.Any())
                {
                    if (excludeKeys.Contains(iter.Key)) continue;
                }
                if (!string.IsNullOrEmpty(iter.Value))
                {
                    sb.Append(iter.Key).Append('=').Append(iter.Value).Append('&');
                }
            }

            var signContent = sb.Append("key=").Append(key).ToString();

            return signContent;
        }
    }
}