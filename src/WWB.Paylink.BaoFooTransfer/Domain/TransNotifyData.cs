using System.Xml.Serialization;

namespace WWB.Paylink.BaoFooTransfer.Domain
{
    public class TransNotifyData
    {
        [XmlElement("trans_orderid")] public string TransOrderId { get; set; }
        [XmlElement("trans_batchid")] public string TransBatchId { get; set; }
        [XmlElement("trans_no")] public string TransNo { get; set; }
        [XmlElement("trans_money")] public string TransMoney { get; set; }
        [XmlElement("to_acc_name")] public string ToAccName { get; set; }
        [XmlElement("to_acc_no")] public string ToAccNo { get; set; }
        [XmlElement("trans_fee")] public string TransFee { get; set; }
        [XmlElement("state")] public int State { get; set; }
        [XmlElement("trans_remark")] public string TransRemark { get; set; }
        [XmlElement("trans_starttime")] public string TransStartTime { get; set; }
        [XmlElement("trans_endtime")] public string TransEndTime { get; set; }
        [XmlElement("trans_reserved")] public string TransReserved { get; set; }
    }
}