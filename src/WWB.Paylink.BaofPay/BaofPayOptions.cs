using Org.BouncyCastle.Crypto;

namespace WWB.Paylink.BaofPay;

public class BaofPayOptions
{
    private string privateCert;
    private string privateCertPassword;
    private string publicCert;

    /// <summary>
    /// 商户号
    /// </summary>
    public string MchId { get; set; }

    /// <summary>
    /// 终端号
    /// </summary>
    public string TerminalId { get; set; }

    /// <summary>
    /// 签名混淆KEY
    /// </summary>
    public string Key { get; set; }

    /// <summary>
    /// 商户私钥。可为 证书文件路径、证书文件的Base64编码。
    /// </summary>
    public string PrivateCert
    {
        get => privateCert;
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                privateCert = value;
                GetPrivateCertInfo();
            }
        }
    }

    /// <summary>
    /// 商户私钥密码
    /// </summary>
    public string PrivateCertPassword
    {
        get => privateCertPassword;
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                privateCertPassword = value;
                GetPrivateCertInfo();
            }
        }
    }

    public string PublicCert
    {
        get => publicCert;
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                publicCert = value;
                try
                {
                    RSAPublicKey = RSAUtil.GetPublicKeyFromFile(value);
                }
                catch (CryptographicException ex)
                {
                    throw new BaofPayException($"反序列化公钥失败，请确认是否为签发的有效PKCS#12格式证书。原始异常信息：{ex.Message}");
                }
            }
        }
    }

    /// <summary>
    /// 商户私钥RSA
    /// </summary>
    internal AsymmetricKeyParameter RSAPrivateKey { get; private set; }

    /// <summary>
    /// 惠收钱公钥
    /// </summary>
    internal AsymmetricKeyParameter RSAPublicKey { get; private set; }

    private void GetPrivateCertInfo()
    {
        if (string.IsNullOrEmpty(PrivateCert) || string.IsNullOrEmpty(PrivateCertPassword))
        {
            return;
        }

        try
        {
            RSAPrivateKey = RSAUtil.GetPrivateKeyFromFile(privateCert, privateCertPassword);
        }
        catch (CryptographicException ex)
        {
            throw new BaofPayException($"反序列化私钥失败，请确认是否为签发的有效PKCS#12格式证书。原始异常信息：{ex.Message}");
        }
    }
}