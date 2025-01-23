namespace WWB.Paylink.BaoFooTransfer.Response.BCT
{
    public class BCTAccResponseBodyBase
    {
        public int retCode { get; set; }
        public string errorCode { get; set; }
        public string errorMsg { get; set; }
        public string back1 { get; set; }
        public string back2 { get; set; }
        public string back3 { get; set; }
    }
}