using System.Collections.Generic;
using System.Text;
using WWB.Paylink.Utility.Security;

namespace WWB.Paylink.JoinPay
{
    /// <summary>
    /// 签名
    /// </summary>
    public static class JoinPaySignature
    {
        public static string SignWithKey(IDictionary<string, string> dictionary, string key, JoinPaySignType signType)
        {
            var sb = new StringBuilder();
            foreach (var iter in dictionary)
            {
                if (!string.IsNullOrWhiteSpace(iter.Value) && iter.Key != JoinPayConsts.sign)
                {
                    sb.Append(iter.Value);
                }
            }

            var signContent = sb.Append(key).ToString();

            return signType switch
            {
                JoinPaySignType.MD5 => MD5.Compute(signContent).ToUpperInvariant(),
                _ => throw new JoinPayException("Unknown sign type!"),
            };
        }
    }
}