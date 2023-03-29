using Newtonsoft.Json;
using System.IO;
using System.Xml.Serialization;
using WWB.Paylink.BaoFooTransfer.Domain;
using WWB.Paylink.Utility.Security;

namespace WWB.Paylink.BaoFooTransfer.Notify
{
    /// <summary>
    /// 公共参数
    /// </summary>
    public class TransferNotify : BaseNotify
    {
        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        [JsonProperty("terminal_id")]
        public string TerminalId { get; set; }

        /// <summary>
        /// 数据类型。xml或json
        /// </summary>
        [JsonProperty("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 请求报文（加密串）
        /// </summary>
        [JsonProperty("data_content")]
        public string DataContent { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// 返回结果对象
        /// </summary>
        [JsonIgnore]
        public TransContent<TransNotifyData> ResultData { get; set; }

        internal override void Execute(BaoFooTransOptions options)
        {
            if (string.IsNullOrWhiteSpace(DataContent)) return;

            //解密data_content
            DataContent = RSAHelper.DecryptByCer(DataContent, options.CerCertificate);

            //xml反序列化
            var serializer = new XmlSerializer(typeof(TransContent<TransNotifyData>));

            using TextReader reader = new StringReader(DataContent);
            ResultData = serializer.Deserialize(reader) as TransContent<TransNotifyData>;
        }
    }
}