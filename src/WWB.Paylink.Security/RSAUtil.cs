using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;
using System.Text;

namespace WWB.Paylink.Security;

public static class RSAUtil
{
    public static AsymmetricKeyParameter GetPrivateKeyFromFile(string path, string pwd)
    {
        FileStream input = File.OpenRead(path);
        char[] password = pwd.ToCharArray();
        Pkcs12Store pkcs12Store = new Pkcs12StoreBuilder().Build();
        pkcs12Store.Load(input, password);
        string alias = null;
        foreach (string alias2 in pkcs12Store.Aliases)
        {
            if (pkcs12Store.IsKeyEntry(alias2))
            {
                alias = alias2;
            }
        }

        AsymmetricKeyEntry key = pkcs12Store.GetKey(alias);
        return key.Key;
    }

    public static AsymmetricKeyParameter GetPublicKeyFromFile(string path)
    {
        System.Security.Cryptography.X509Certificates.X509Certificate x509Cert = System.Security.Cryptography.X509Certificates.X509Certificate.CreateFromCertFile(path);
        Org.BouncyCastle.X509.X509Certificate x509Certificate = DotNetUtilities.FromX509Certificate(x509Cert);
        return x509Certificate.GetPublicKey();
    }

    public static string PrivateKeyEncrypt(string src, string path, string passwd)
    {
        var privateKey = GetPrivateKeyFromFile(path, passwd);

        return PrivateKeyEncrypt(src, privateKey);
    }

    public static string PrivateKeyEncrypt(string src, AsymmetricKeyParameter privateKey)
    {
        byte[] src2 = Base64.Encode(Encoding.UTF8.GetBytes(src));
        return Hex.ToHexString(RSAEDCore(src2, privateKey, Mode: true));
    }

    public static string PublicKeyDecrypt(string src, string path)
    {
        var publicKey = GetPublicKeyFromFile(path);

        return PublicKeyDecrypt(src, publicKey);
    }

    public static string PublicKeyDecrypt(string src, AsymmetricKeyParameter publicKey)
    {
        byte[] src2 = Hex.Decode(src);
        byte[] data = RSAEDCore(src2, publicKey, Mode: false);
        return Encoding.UTF8.GetString(Base64.Decode(data));
    }

    private static byte[] RSAEDCore(byte[] Src, AsymmetricKeyParameter PFXorCER, bool Mode)
    {
        IAsymmetricBlockCipher asymmetricBlockCipher = new RsaEngine();
        IBufferedCipher cipher = CipherUtilities.GetCipher("RSA/ECB/PKCS1Padding");
        cipher.Init(Mode, PFXorCER);
        byte[] array = null;
        int blockSize = cipher.GetBlockSize();
        for (int i = 0; i < Src.Length; i += blockSize)
        {
            byte[] array2 = cipher.DoFinal(Subarray(Src, i, i + blockSize));
            array = AddAll(array, array2);
        }

        return array;
    }

    private static byte[] Subarray(byte[] array, int startIndexInclusive, int endIndexExclusive)
    {
        if (array == null)
        {
            throw new IOException("byte[] array内容为空！异常：subarray(byte[],int,int)");
        }

        if (endIndexExclusive > array.Length)
        {
            endIndexExclusive = array.Length;
        }

        int num = endIndexExclusive - startIndexInclusive;
        if (num <= 0)
        {
            return new byte[0];
        }

        byte[] array2 = new byte[num];
        Array.Copy(array, startIndexInclusive, array2, 0, num);
        return array2;
    }

    public static byte[] AddAll(byte[] array1, byte[] array2)
    {
        if (array1 == null)
        {
            return Clone(array2);
        }

        if (array2 == null)
        {
            return Clone(array1);
        }

        byte[] array3 = new byte[array1.Length + array2.Length];
        Array.Copy(array1, 0, array3, 0, array1.Length);
        Array.Copy(array2, 0, array3, array1.Length, array2.Length);
        return array3;
    }

    public static byte[] Clone(byte[] array)
    {
        if (array == null)
        {
            return null;
        }

        return (byte[])array.Clone();
    }
}