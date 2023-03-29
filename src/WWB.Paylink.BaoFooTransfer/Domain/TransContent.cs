using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace WWB.Paylink.BaoFooTransfer.Domain
{
    [XmlRoot("trans_content")]
    [Serializable]
    public class TransContent<T> where T : class, new()
    {
        [XmlElement("trans_head")]
        [JsonProperty("trans_head")]
        public TransHead TransHead { get; set; }

        [XmlElement("trans_reqDatas")]
        [JsonProperty("trans_reqDatas")]
        public List<TransReqDatas<T>> TransReqDatas { get; set; }
    }
}