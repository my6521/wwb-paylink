using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;
using System.Text;

namespace WWB.Paylink.Utility.Security
{
    public static class RSAHelper
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
                var publicKey = CertificateHelper.GetPublicKeyFromFile(path); //读取公钥
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
                var privateKey = CertificateHelper.GetPrivateKeyFromFile(path, passwd); //读取私钥
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
                var publicKey = CertificateHelper.GetPrivateKeyFromFile(path, passwd); //读取私钥
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
                var publicKey = CertificateHelper.GetPublicKeyFromFile(path); //读取公钥
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

        #endregion Private Methods
    }
}