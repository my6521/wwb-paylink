using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Utilities.Encoders;
using Org.BouncyCastle.X509;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WWB.Paylink.Utility.Security
{
    public static class RsaReadUtil
    {
        private static Dictionary<string, AsymmetricKeyParameter> m_keys = new Dictionary<string, AsymmetricKeyParameter>();

        /// <summary>
        /// 读取私钥
        /// </summary>
        /// <param name="path">证书路径</param>
        /// <param name="pwd">证书密码</param>
        /// <returns></returns>
        public static AsymmetricKeyParameter GetPrivateKeyFromFile(string path, string pwd)
        {
            if (m_keys.ContainsKey(path))
            {
                return m_keys[path];
            }

            var passwd = pwd.ToCharArray();
            var store = new Pkcs12StoreBuilder().Build();
            //path路径下证书
            using (var fs = File.OpenRead(path))
            {
                store.Load(fs, passwd); //加载证书
            }

            string alias = null;
            foreach (var str in store.Aliases)
            {
                if (store.IsKeyEntry(str))
                    alias = str;
            }

            var keyEntry = store.GetKey(alias);
            m_keys[path] = keyEntry.Key;

            return keyEntry.Key;
        }

        /// <summary>
        /// 读取公钥
        /// </summary>
        /// <param name="path">证书路径</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static AsymmetricKeyParameter GetPublicKeyFromFile(string path)
        {
            if (m_keys.ContainsKey(path))
            {
                return m_keys[path];
            }

            string line = null;
            var keyBuffer = new StringBuilder();

            using (var sr = new StreamReader(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (!line.StartsWith("-"))
                    {
                        keyBuffer.Append(line);
                    }
                }
            }

            if (string.IsNullOrEmpty(keyBuffer.ToString().Trim()))
            {
                throw new Exception("公钥读取异常[keyBuffer=null or Empty]");
            }

            var cerObj = new X509CertificateParser().ReadCertificate(Base64.Decode(keyBuffer.ToString()));
            var result = cerObj.GetPublicKey();

            m_keys[path] = result;

            return result;
        }
    }
}