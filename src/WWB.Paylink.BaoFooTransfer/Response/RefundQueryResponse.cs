namespace WWB.Paylink.BaoFooTransfer.Response
{
    public class RefundQueryResponse : BaseResponse
    {
        public TransContent<RefundQueryRespData> trans_content { get; set; }
    }
}