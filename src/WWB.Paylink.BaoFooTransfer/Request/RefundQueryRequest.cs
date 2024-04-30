using System.Collections.Generic;
using WWB.Paylink.BaoFooTransfer.Domain;
using WWB.Paylink.BaoFooTransfer.Domain.Request;
using WWB.Paylink.BaoFooTransfer.Response;

namespace WWB.Paylink.BaoFooTransfer.Request
{
    /// <summary>
    /// 代付交易退款查询
    /// </summary>
    public class RefundQueryRequest : BaseTransRequest, IBaoFooTransRequest<RefundQueryResponse>
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
                throw new BaoFooTransException("查询参数不能为空");
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