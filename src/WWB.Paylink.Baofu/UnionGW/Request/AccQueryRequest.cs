using WWB.Paylink.Baofu.UnionGW.Response;

namespace WWB.Paylink.Baofu.UnionGW.Request
{
    /// <summary>
    /// 开户信息查询
    /// </summary>
    public class AccQueryRequest : BaseUnionGWRRequest, IBaofuRequest<BaseUnionGWResponse<AccQueryResponse>>
    {
        public AccQueryRequest() : base(ServiceTpConsts.开户信息查询)
        {
        }

        /// <summary>
        /// 版本号
        /// </summary>
        public string version { get; set; } = "4.0.0";

        /// <summary>
        /// 证件号码（社会信用代码）
        /// </summary>
        public string certificateNo { get; set; }

        /// <summary>
        /// 证件类型 只能取”ID”或”LICENSE”
        /// </summary>
        public string certificateType { get; set; }

        /// <summary>
        /// 平台号(主商户号)
        /// </summary>
        public string platformNo { get; set; }

        /// <summary>
        /// 登录号(传此参数以上三个参数必填)
        /// </summary>
        public string loginNo { get; set; }

        /// <summary>
        /// 客户账户号(传此参数以上四个参数可以不填)
        /// </summary>
        public string contractNo { get; set; }

        /// <summary>
        /// 账户类型:1个人,2商户
        /// </summary>
        public int accType { get; set; }
    }
}