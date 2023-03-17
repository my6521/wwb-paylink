namespace WWB.Paylink.BaoFooTransfer.Domain;

[Serializable]
public class TransReqDatas<T> where T : BaofPayObject
{
    [XmlElement("trans_reqData")]
    [JsonConverter(typeof(SafeCollectionConverter))]
    public List<T> trans_reqData { get; set; }
}