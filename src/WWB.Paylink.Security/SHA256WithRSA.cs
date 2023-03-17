using Org.BouncyCastle.Utilities.Encoders;
using System.Security.Cryptography;
using System.Text;

namespace WWB.Paylink.Security;

public static class SHA256WithRSA
{
    public static string Sign(RSA rsa, string data)
    {
        if (rsa == null)
        {
            throw new ArgumentNullException(nameof(rsa));
        }

        if (string.IsNullOrEmpty(data))
        {
            throw new ArgumentNullException(nameof(data));
        }

        return Hex.ToHexString(rsa.SignData(Encoding.UTF8.GetBytes(data), HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1));
    }

    public static bool Verify(RSA rsa, string data, string sign)
    {
        if (rsa == null)
        {
            throw new ArgumentNullException(nameof(rsa));
        }

        if (string.IsNullOrEmpty(data))
        {
            throw new ArgumentNullException(nameof(data));
        }

        if (string.IsNullOrEmpty(sign))
        {
            throw new ArgumentNullException(nameof(sign));
        }

        return rsa.VerifyData(Encoding.UTF8.GetBytes(data), Hex.Decode(sign), HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
    }
}