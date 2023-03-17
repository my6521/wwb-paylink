namespace WWB.Paylink.HsqPay;

public class HsqPayOptions
{
    private string privateCert;
    private string privateCertPassword;
    private string publicCert;

    /// <summary>
    /// 商户号
    /// </summary>
    public string MchId { get; set; }

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
                    X509Certificate2 certificate;
                    if (File.Exists(PrivateCert))
                    {
                        certificate = new X509Certificate2(publicCert, string.Empty, X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.Exportable);
                    }
                    else
                    {
                        certificate = new X509Certificate2(Convert.FromBase64String(publicCert));
                    }

                    if (RSAPublicKey == null)
                    {
                        RSAPublicKey = certificate.GetRSAPublicKey();
                    }
                }
                catch (CryptographicException ex)
                {
                    throw new HsqPayException($"反序列化公钥失败，请确认是否为签发的有效PKCS#12格式证书。原始异常信息：{ex.Message}");
                }
            }
        }
    }

    /// <summary>
    /// 商户私钥RSA
    /// </summary>
    internal RSA RSAPrivateKey { get; private set; }

    /// <summary>
    /// 惠收钱公钥
    /// </summary>
    internal RSA RSAPublicKey { get; private set; }

    private void GetPrivateCertInfo()
    {
        if (string.IsNullOrEmpty(PrivateCert) || string.IsNullOrEmpty(PrivateCertPassword))
        {
            return;
        }

        try
        {
            X509Certificate2 certificate;
            if (File.Exists(PrivateCert))
            {
                certificate = new X509Certificate2(PrivateCert, PrivateCertPassword, X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.Exportable);
            }
            else
            {
                certificate = new X509Certificate2(Convert.FromBase64String(PrivateCert), PrivateCertPassword, X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.Exportable);
            }

            if (RSAPrivateKey == null)
            {
                RSAPrivateKey = certificate.GetRSAPrivateKey();
            }
        }
        catch (CryptographicException ex)
        {
            throw new HsqPayException($"反序列化私钥失败，请确认是否为签发的有效PKCS#12格式证书。原始异常信息：{ex.Message}");
        }
    }
}