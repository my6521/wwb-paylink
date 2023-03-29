using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using WWB.Paylink.Utility.Converter;

namespace WWB.Paylink.BaoFooTransfer.Domain
{
    [Serializable]
    public class TransReqDatas<T> where T : class, new()
    {
        [XmlElement("trans_reqData")]
        [JsonProperty("trans_reqData")]
        [JsonConverter(typeof(SafeCollectionConverter))]
        public List<T> TransReqData { get; set; }
    }
}