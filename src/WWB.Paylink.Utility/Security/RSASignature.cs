using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;
using System.Text;

namespace WWB.Paylink.Utility.Security
{
    public static class RSASignature
    {
        /// <summary>
        /// 公共方法验签
        /// </summary>
        /// <param name="pubCerPath"></param>
        /// <param name="encryptStr"></param>
        /// <param name="signature"></param>
        /// <returns></returns>
        public static bool Verify(string pubCerPath, string encryptStr, string signature)
        {
            var publicKey = CertificateHelper.GetPublicKeyFromFile(pubCerPath);
            return Verify(Encoding.UTF8.GetBytes(encryptStr), publicKey, signature);
        }

        /// <summary>
        /// 公共方法加签
        /// </summary>
        /// <param name="encryptStr"></param>
        /// <param name="pfxPath"></param>
        /// <param name="priKeyPass"></param>
        /// <returns></returns>
        public static string Sign(string encryptStr, string pfxPath, string priKeyPass)
        {
            var privateKey = CertificateHelper.GetPrivateKeyFromFile(pfxPath, priKeyPass);
            return Sign(Encoding.UTF8.GetBytes(encryptStr), privateKey);
        }

        /// <summary>
        /// 用私钥对信息生成数字签名
        /// 私钥加签
        /// </summary>
        /// <param name="data"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        private static string Sign(byte[] data, ICipherParameters parameters)
        {
            var signature = SignerUtilities.GetSigner("SHA256withRSA");
            signature.Init(true, parameters);
            signature.BlockUpdate(data, 0, data.Length);
            return Hex.ToHexString(signature.GenerateSignature());
        }

        /// <summary>
        /// 校验数字签名
        /// 公钥验签
        /// </summary>
        /// <param name="data"></param>
        /// <param name="parameters"></param>
        /// <param name="sign"></param>
        /// <returns></returns>
        private static bool Verify(byte[] data, ICipherParameters parameters, string sign)
        {
            var signature = SignerUtilities.GetSigner("SHA256withRSA");
            signature.Init(false, parameters);
            signature.BlockUpdate(data, 0, data.Length);
            return signature.VerifySignature(Hex.Decode(sign));
        }
    }
}