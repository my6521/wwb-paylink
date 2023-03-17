namespace WWB.Paylink.BaoFooPay.Domain.ResResult
{
    public class ComplaintQueryResponseResult
    {
        public int offset { get; set; }
        public int totalSize { get; set; }
        public string data { get; set; }
        public string complaintId { get; set; }
        public string merchantTradeNo { get; set; }
        public string amount { get; set; }
        public string complaintState { get; set; }
        public string complaintTime { get; set; }
        public string problemDescription { get; set; }
        public string complaintDetail { get; set; }
        public string userComplaintTimes { get; set; }
        public string incomingUserResponse { get; set; }
        public string payerOpenid { get; set; }
        public string merchantNo { get; set; }
        public string agentNo { get; set; }
        public string payerPhone { get; set; }
        public string complaintFullRefunded { get; set; }
    }
}