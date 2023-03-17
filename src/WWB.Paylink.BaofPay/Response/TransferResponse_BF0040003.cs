namespace WWB.Paylink.BaofPay.Response;

public class TransferResponse_BF0040003 : BaofPayResponse
{
    public TransContent<TransRespData_BF0040003> trans_content { get; set; }
}