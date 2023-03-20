using WWB.Paylink.BaoFooTransfer.Domain;
using WWB.Paylink.BaoFooTransfer.Domain.Response;

namespace WWB.Paylink.BaoFooTransfer.Response
{
    public class TransferSplitResponse : BaseResponse
    {
        public TransContent<TransSplitRespData> trans_content { get; set; }
    }
}