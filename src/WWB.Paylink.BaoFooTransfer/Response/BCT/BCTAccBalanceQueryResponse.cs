namespace WWB.Paylink.BaoFooTransfer.Response.BCT
{
    public class BCTAccBalanceQueryResponse : BaseUnionGWResponse<BCTAccBalanceQueryResponseBody>
    {
    }

    public class BCTAccBalanceQueryResponseBody : BaseUnionGWResponseBodyBase
    {
        public decimal availableBal { get; set; }
        public decimal pendingBal { get; set; }
        public decimal currBal { get; set; }
    }
}