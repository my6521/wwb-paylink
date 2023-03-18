using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;
using WWB.Paylink.BaoFooTransfer.Domain;
using WWB.Paylink.Utility.Security;

namespace WWB.Paylink.BaoFooTransfer.Notify
{
    public class TransferNotify : BaseNotify
    {
        public string member_id { get; set; }
        public string terminal_id { get; set; }
        public string data_type { get; set; }
        public string data_content { get; set; }
        public string version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonIgnore] 
        public TransContent<TransNotifyData> ResultData { get; set; }

        internal override void Execute(BaoFooTransOptions options)
        {
            if (string.IsNullOrWhiteSpace(data_content)) return;

            //解密data_content
            data_content = RSAHelper.DecryptByCer(data_content, options.CerCertificate);

            //xml反序列化
            var serializer = new XmlSerializer(typeof(TransContent<TransNotifyData>));

            using TextReader reader = new StringReader(data_content);
            ResultData = serializer.Deserialize(reader) as TransContent<TransNotifyData>;
        }
    }
}