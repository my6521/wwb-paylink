using Newtonsoft.Json;
using System.IO;
using System.Xml.Serialization;
using WWB.Paylink.BaoFooTransfer.Domain;
using WWB.Paylink.Utility.Security;

namespace WWB.Paylink.BaoFooTransfer.Notify
{
    public class TransferNotify : BaseNotify
    {
        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        [JsonProperty("terminal_id")]
        public string TerminalId { get; set; }

        [JsonProperty("data_type")]
        public string DataType { get; set; }

        [JsonProperty("data_content")]
        public string DataContent { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        ///
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