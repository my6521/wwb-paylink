namespace WWB.Paylink.BaofPay.Domain.Response;

public class TransRespData_BF0040001 : BaofPayObject
{
    public string trans_orderid { get; set; }
    public string trans_batchid { get; set; }
    public string trans_no { get; set; }
    public string trans_money { get; set; }
    public string to_acc_name { get; set; }
    public string to_acc_no { get; }
    public string to_acc_dept { get; }
    public string trans_summary { get; set; }
    public string trans_reserved { get; set; }
}