using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.IO;
using System.Text;

namespace WWB.Paylink.Utility.Security
{
    public static class RSAUtil
    {
        #region 加密

        /// <summary>
        /// 公钥加密
        /// </summary>
        /// <param name="data">加密数据</param>
        /// <param name="path">证书路径</param>
        /// <returns></returns>
        public static string EncryptByCer(string data, string path)
        {
            try
            {
                var publicKey = RsaReadUtil.GetPublicKeyFromFile(path); //读取公钥
                var string64 = Base64.Encode(Encoding.UTF8.GetBytes(data)); //Base64编码  字符编码UF8
                var hex = Hex.ToHexString(RSAEDCore(string64, publicKey, true)); //加密并转成十六进制
                return hex;
            }
            catch (Exception ex)
            {
                return "{[本地加密异常][EncryptRSAByPfx][" + ex.Message + "]}";
            }
        }

        /// <summary>
        /// 私钥加密
        /// </summary>
        /// <param name="data">加密数据</param>
        /// <param name="path">证书路径</param>
        /// <param name="passwd">密码</param>
        /// <returns></returns>
        public static string EncryptByPfx(string data, string path, string passwd)
        {
            try
            {
                var privateKey = RsaReadUtil.GetPrivateKeyFromFile(path, passwd); //读取私钥
                var string64 = Base64.Encode(Encoding.UTF8.GetBytes(data)); //Base64编码  字符编码UF8
                var hex = Hex.ToHexString(RSAEDCore(string64, privateKey, true)); //加密并转成十六进制
                return hex;
            }
            catch (Exception ex)
            {
                return "{[本地加密异常][EncryptRSAByPfx][" + ex.Message + "]}";
            }
        }

        #endregion 加密

        #region 解密

        /// <summary>
        /// 私钥解密
        /// </summary>
        /// <param name="data">解密数据</param>
        /// <param name="path">证书路径</param>
        /// <param name="passwd">密码</param>
        /// <returns></returns>
        public static string DecryptByPfx(string data, string path, string passwd)
        {
            try
            {
                var publicKey = RsaReadUtil.GetPrivateKeyFromFile(path, passwd); //读取私钥
                var hexByte = Hex.Decode(data);
                var decryString = RSAEDCore(hexByte, publicKey, false);
                return Encoding.UTF8.GetString(Base64.Decode(decryString));
            }
            catch (Exception ex)
            {
                return "{[本地解密异常][DecryptRSAByCer][" + ex.Message + "]}";
            }
        }

        /// <summary>
        /// 公钥解密
        /// </summary>
        /// <param name="data">解密数据</param>
        /// <param name="path">证书路径</param>
        /// <returns></returns>
        public static string DecryptByCer(string data, string path)
        {
            try
            {
                var publicKey = RsaReadUtil.GetPublicKeyFromFile(path); //读取公钥
                var hexByte = Hex.Decode(data);
                var decryString = RSAEDCore(hexByte, publicKey, false);
                return Encoding.UTF8.GetString(Base64.Decode(decryString));
            }
            catch (Exception ex)
            {
                return "{[本地解密异常][DecryptRSAByCer][" + ex.Message + "]}";
            }
        }

        #endregion 解密

        #region 加签

        /// <summary>
        /// 私钥加签
        /// </summary>
        /// <param name="encryptStr"></param>
        /// <param name="pfxPath"></param>
        /// <param name="priKeyPass"></param>
        /// <returns></returns>
        public static string SignByPfx(string encryptStr, string pfxPath, string priKeyPass)
        {
            var privateKey = RsaReadUtil.GetPrivateKeyFromFile(pfxPath, priKeyPass);
            return Sign(Encoding.UTF8.GetBytes(encryptStr), privateKey);
        }


        /// <summary>
        /// 公钥加签
        /// </summary>
        /// <param name="encryptStr"></param>
        /// <param name="pubCerPath"></param>
        /// <returns></returns>
        public static string SignByCer(string encryptStr, string pubCerPath)
        {
            var publicKey = RsaReadUtil.GetPublicKeyFromFile(pubCerPath);
            return Sign(Encoding.UTF8.GetBytes(encryptStr), publicKey);
        }
        #endregion

        #region 验签
        /// <summary>
        /// 公钥验签
        /// </summary>
        /// <param name="pubCerPath"></param>
        /// <param name="encryptStr"></param>
        /// <param name="signature"></param>
        /// <returns></returns>
        public static bool VerifyByCer(string pubCerPath, string encryptStr, string signature)
        {
            var publicKey = RsaReadUtil.GetPublicKeyFromFile(pubCerPath);
            return Verify(Encoding.UTF8.GetBytes(encryptStr), publicKey, signature);
        }

        /// <summary>
        /// 私钥验签
        /// </summary>
        /// <param name="pfxPath"></param>
        /// <param name="priKeyPass"></param>
        /// <param name="encryptStr"></param>
        /// <param name="signature"></param>
        /// <returns></returns>
        public static bool VerifyByPfx(string pfxPath, string priKeyPass, string encryptStr, string signature)
        {
            var publicKey = RsaReadUtil.GetPrivateKeyFromFile(pfxPath, priKeyPass);
            return Verify(Encoding.UTF8.GetBytes(encryptStr), publicKey, signature);
        }
        #endregion

        #region Private Methods

        /// <summary>
        /// 加密核心
        /// </summary>
        /// <param name="data">加密内容</param>
        /// <param name="pfxorCer">证书</param>
        /// <param name="mode">加密或解密  true  OR  false</param>
        /// <returns></returns>
        private static byte[] RSAEDCore(byte[] data, AsymmetricKeyParameter pfxorCer, bool mode)
        {
            // var engine = new RsaEngine();
            var cipher = CipherUtilities.GetCipher("RSA/ECB/PKCS1Padding"); //加密标准

            cipher.Init(mode, pfxorCer); //初始加密程序

            byte[] edString = null;

            var blockSize = cipher.GetBlockSize(); //获取分段长度

            for (var i = 0; i < data.Length; i += blockSize)
            {
                var outBytes = cipher.DoFinal(Subarray(data, i, i + blockSize)); //数据加密
                edString = AddAll(edString, outBytes);
            }

            return edString;
        }

        /// <summary>
        /// 数据分块算法
        /// </summary>
        /// <param name="array">源长度</param>
        /// <param name="startIndexInclusive">开始长度</param>
        /// <param name="endIndexExclusive">结束长度</param>
        /// <returns></returns>
        /// <exception cref="IOException"></exception>
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

            var newSize = endIndexExclusive - startIndexInclusive;
            if (newSize <= 0)
            {
                return Array.Empty<byte>();
            }

            var subarray = new byte[newSize];
            Array.Copy(array, startIndexInclusive, subarray, 0, newSize);
            return subarray;
        }

        private static byte[] AddAll(byte[] array1, byte[] array2)
        {
            if (array1 == null)
            {
                return Clone(array2);
            }
            else if (array2 == null)
            {
                return Clone(array1);
            }

            var joinedArray = new byte[array1.Length + array2.Length];
            Array.Copy(array1, 0, joinedArray, 0, array1.Length);
            Array.Copy(array2, 0, joinedArray, array1.Length, array2.Length);
            return joinedArray;
        }

        private static byte[] Clone(byte[] array)
        {
            if (array is null)
            {
                return null;
            }

            return (byte[])array.Clone();
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

        #endregion Private Methods
    }
}