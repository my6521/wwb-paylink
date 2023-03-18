using WWB.Paylink.BaoFooTransfer.Domain;
using WWB.Paylink.BaoFooTransfer.Domain.Response;

namespace WWB.Paylink.BaoFooTransfer.Response
{
    public class TransferQueryResponse : BaseResponse
    {
        public TransContent<TransQueryRespData> trans_content { get; set; }
    }
}