using System.Text;

namespace WWB.Paylink.Utility
{
    public static class ToolHelper
    {
        public static string GetSignContent(IDictionary<string, string> dictionary, string key)
        {
            var sb = new StringBuilder();
            foreach (var iter in dictionary)
            {
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