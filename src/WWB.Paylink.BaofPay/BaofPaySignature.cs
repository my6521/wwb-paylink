namespace WWB.Paylink.BaofPay;

public static class BaofPaySignature
{
    public static string Encrypt(string data, BaofPayOptions options)
    {
        return RSAUtil.PrivateKeyEncrypt(data, options.RSAPrivateKey);
    }

    public static string Decrypt(string data, BaofPayOptions options)
    {
        return RSAUtil.PublicKeyDecrypt(data, options.RSAPublicKey);
    }
}