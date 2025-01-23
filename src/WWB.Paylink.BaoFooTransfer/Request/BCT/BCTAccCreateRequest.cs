using WWB.Paylink.BaoFooTransfer.Response.BCT;

namespace WWB.Paylink.BaoFooTransfer.Request.BCT
{
    /// <summary>
    /// 个人/机构开户接口
    /// </summary>
    public class BCTAccCreateRequest : BaseUnionGWRRequest, IBaoFooTransRequest<BCTAccCreateResponse>
    {
        private const string serviceTp = "T-1001-013-01";

        public BCTAccCreateRequest() : base(serviceTp)
        {
        }

        public string version { get; set; } = "4.1.0";
        public int accType { get; set; }
        public object accInfo { get; set; }
        public string noticeUrl { get; set; }
        public string businessType { get; set; } = "BCT2.0";

        public class PersonAccInfo
        {
            public string transSerialNo { get; set; }
            public string loginNo { get; set; }
            public string customerName { get; set; }
            public string certificateType { get; set; }
            public string certificateNo { get; set; }
            public string cardNo { get; set; }
            public string mobileNo { get; set; }
            public string cardUserName { get; set; }
            public bool needUploadFile { get; set; }
            public string platformNo { get; set; }
            public string platformTerminalId { get; set; }
            public string qualificationTransSerialNo { get; set; }
        }

        public class CompanyAccInfo
        {
            public string transSerialNo { get; set; }
            public string loginNo { get; set; }
            public string email { get; set; }
            public bool selfEmployed { get; set; }
            public string customerName { get; set; }
            public string aliasName { get; set; }
            public string certificateNo { get; set; }
            public string certificateType { get; set; }
            public string corporateName { get; set; }
            public string corporateCertType { get; set; }
            public string corporateCertId { get; set; }
            public string corporateMobile { get; set; }
            public string industryId { get; set; }
            public string contactName { get; set; }
            public string contactMobile { get; set; }
            public string cardNo { get; set; }
            public string bankName { get; set; }
            public string depositBankProvince { get; set; }
            public string depositBankCity { get; set; }
            public string depositBankName { get; set; }
            public string registerCapital { get; set; }
            public string cardUserName { get; set; }
            public string platformNo { get; set; }
            public string platformTerminalId { get; set; }
            public string qualificationTransSerialNo { get; set; }
        }
    }
}