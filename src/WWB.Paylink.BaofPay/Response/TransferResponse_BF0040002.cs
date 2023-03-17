namespace WWB.Paylink.BaofPay.Response;

public class TransferResponse_BF0040002 : BaofPayResponse
{
    public TransContent<TransRespData_BF0040002> trans_content { get; set; }
}