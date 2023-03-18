using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;
using WWB.Paylink.Utility.Converter;

namespace WWB.Paylink.BaoFooTransfer.Domain
{
    [Serializable]
    public class TransReqDatas<T> where T : class, new()
    {
        [XmlElement("trans_reqData")]
        [JsonConverter(typeof(SafeCollectionConverter))]
        public List<T> trans_reqData { get; set; }
    }
}