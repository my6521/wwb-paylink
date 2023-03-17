namespace WWB.Paylink.BaoFooTransfer.Domain
{
    [XmlRoot("trans_content")]
    [Serializable]
    public class TransContent<T> where T : class, new()
    {
        [XmlElement("trans_head")]
        public TransHead trans_head { get; set; }

        [XmlElement("trans_reqDatas")]
        public List<TransReqDatas<T>> trans_reqDatas { get; set; }
    }
}