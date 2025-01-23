using WWB.Paylink.BaoFooTransfer.Response.BCT;

namespace WWB.Paylink.BaoFooTransfer.Request.BCT
{
    public class BCTAccCardEditRequest : BaseUnionGWRRequest, IBaoFooTransRequest<BCTAccCardEditResponse>
    {
        private const string serviceTp = "T-1001-013-02";

        public BCTAccCardEditRequest() : base(serviceTp)
        {
        }

        public string version { get; set; } = "4.1.0";
        public int accType { get; set; }
        public object accInfo { get; set; }

        public class PersonCardInfo
        {
            public string contractNo { get; set; }
            public string transSerialNo { get; set; }
            public string cardNo { get; set; }
            public string mobileNo { get; set; }
        }

        public class CompanyCardInfo
        {
            public string contractNo { get; set; }
            public string transSerialNo { get; set; }
            public string cardNo { get; set; }
            public string bankName { get; set; }
            public string depositBankProvince { get; set; }
            public string depositBankCity { get; set; }
            public string depositBankName { get; set; }
            public string contactName { get; set; }
            public string contactMobile { get; set; }
            public string corporateMobile { get; set; }
        }
    }
}