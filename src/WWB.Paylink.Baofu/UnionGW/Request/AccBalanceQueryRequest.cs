using System.ComponentModel.DataAnnotations;
using WWB.Paylink.Baofu.UnionGW.Response;

namespace WWB.Paylink.Baofu.UnionGW.Request
{
    public class AccBalanceQueryRequest : BaseUnionGWRRequest, IBaofuRequest<BaseUnionGWResponse<AccBalanceQueryResponse>>
    {
        public AccBalanceQueryRequest() : base(ServiceTpConsts.余额查询)
        {
        }

        /// <summary>
        /// 版本号4.0.0
        /// </summary>
        public string version { get; set; } = "4.0.0";

        /// <summary>
        /// 客户号
        /// </summary>
        [Required]
        public string contractNo { get; set; }

        /// <summary>
        /// 账户类型:1个人,2商户
        /// </summary>
        [Required]
        public int accType { get; set; }
    }
}