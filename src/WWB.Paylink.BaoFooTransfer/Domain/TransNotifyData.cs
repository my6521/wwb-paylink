namespace WWB.Paylink.BaoFooTransfer.Domain
{
    public class TransNotifyData
    {
        [XmlElement("trans_orderid")] public string trans_orderid { get; set; }
        [XmlElement("trans_batchid")] public string trans_batchid { get; set; }
        [XmlElement("trans_no")] public string trans_no { get; set; }
        [XmlElement("trans_money")] public string trans_money { get; set; }
        [XmlElement("to_acc_name")] public string to_acc_name { get; set; }
        [XmlElement("to_acc_no")] public string to_acc_no { get; set; }
        [XmlElement("trans_fee")] public string trans_fee { get; set; }
        [XmlElement("state")] public string state { get; set; }
        [XmlElement("trans_remark")] public string trans_remark { get; set; }
        [XmlElement("trans_starttime")] public string trans_starttime { get; set; }
        [XmlElement("trans_endtime")] public string trans_endtime { get; set; }
        [XmlElement("trans_reserved")] public string trans_reserved { get; set; }
    }
}