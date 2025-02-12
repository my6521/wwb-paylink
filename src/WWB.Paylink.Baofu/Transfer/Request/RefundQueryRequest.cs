using System.Collections.Generic;
using WWB.Paylink.Baofu.Transfer.Response;

namespace WWB.Paylink.Baofu.Transfer.Dtos
{
    /// <summary>
    /// 代付交易退款查询
    /// </summary>
    public class RefundQueryRequest : BaseTransRequest, IBaofuRequest<BaseTransResponse<RefundQueryResponse>>
    {
        /// <summary>
        /// 业务参数
        /// </summary>
        public RefundQueryReqData ReqData { get; set; }

        public string GetRequestUrl(bool debug)
        {
            return debug ? "https://paytest.baofoo.com/baofoo-fopay/pay/BF0040003.do" : "https://public.baofoo.com/baofoo-fopay/pay/BF0040003.do";
        }

        protected override object GetData()
        {
            if (ReqData == null)
            {
                throw new BaofuException("查询参数不能为空");
            }

            return new
            {
                trans_content = new TransContent<RefundQueryReqData>
                {
                    TransReqDatas = new List<TransReqDatas<RefundQueryReqData>>
                    {
                        new TransReqDatas<RefundQueryReqData>
                        {
                            TransReqData = new List<RefundQueryReqData>{ ReqData }
                        }
                    }
                }
            };
        }
    }
}