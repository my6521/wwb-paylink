using WWB.Paylink.BaoFooTransfer.Domain;
using WWB.Paylink.BaoFooTransfer.Domain.Response;

namespace WWB.Paylink.BaoFooTransfer.Response;

public class TransferResponse_BF0040001 : BaofPayResponse
{
    public TransContent<TransRespData_BF0040001> trans_content { get; set; }
}