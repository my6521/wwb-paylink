using WWB.Paylink.Baofu.UnionGW.Response;

namespace WWB.Paylink.Baofu.UnionGW.Request
{
    public class AccCardQueryRequest : BaseUnionGWRRequest, IBaofuRequest<BaseUnionGWResponse<AccCardQueryResponse>>
    {
        private const string serviceTp = "T-1001-013-08";

        public AccCardQueryRequest() : base(serviceTp)
        {
        }

        /// <summary>
        /// 版本号4.0.0
        /// </summary>
        public string version { get; set; } = "4.0.0";

        /// <summary>
        /// 登录号(无商户客户号必填)
        /// </summary>
        public string loginNo { get; set; }

        /// <summary>
        /// 客户账户号
        /// </summary>
        public string contractNo { get; set; }

        /// <summary>
        /// 账户类型:1个人,2商户
        /// </summary>
        public int accType { get; set; }

        /// <summary>
        /// 平台号(主商户号)(无商户客户号必填)
        /// </summary>
        public string platformNo { get; set; }
    }
}