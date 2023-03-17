namespace WWB.Paylink.HsqPay;

public static class HsqPaySignature
{
    public static string RSASignContent(IDictionary<string, string> dictionary, HsqPayOptions options, string signType)
    {
        string signContent = GetSignContent(dictionary, options.Key);

        return SHA256WithRSA.Sign(options.RSAPrivateKey, signContent);
    }

    public static bool RSACheckContent(IDictionary<string, string> dictionary, string sign, HsqPayOptions options, string signType)
    {
        string signContent = GetSignContent(dictionary, options.Key);

        return SHA256WithRSA.Verify(options.RSAPublicKey, signContent, sign);
    }

    public static string GetSignContent(IDictionary<string, string> dictionary, string key)
    {
        var sb = new StringBuilder();
        foreach (var iter in dictionary)
        {
            if (!string.IsNullOrEmpty(iter.Value) && iter.Key != HsqPayConsts.SIGN)
            {
                sb.Append(iter.Key).Append('=').Append(iter.Value).Append('&');
            }
        }

        var signContent = sb.Append("key=").Append(key).ToString();

        return signContent;
    }
}