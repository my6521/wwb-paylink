using System.Collections.Generic;
using System.Linq;
using WWB.Paylink.Baofu.Transfer.Response;

namespace WWB.Paylink.Baofu.Transfer.Dtos
{
    /// <summary>
    /// 代付交易拆分
    /// </summary>
    public class TransferSplitRequest : BaseTransRequest, IBaofuRequest<BaseTransResponse<TransferSplitResponse>>
    {
        /// <summary>
        /// 业务参数
        /// </summary>
        public List<TransSplitReqData> DataList { get; set; } = new List<TransSplitReqData>();

        public string GetRequestUrl(bool debug)
        {
            return debug ? "https://paytest.baofoo.com/baofoo-fopay/pay/BF0040004.do" : "https://public.baofoo.com/baofoo-fopay/pay/BF0040004.do";
        }

        protected override object GetData()
        {
            if (!DataList.Any())
            {
                throw new BaofuException("代付交易至少需要一条交易数据");
            }
            if (DataList.Count > 5)
            {
                throw new BaofuException("代付交易一次处理的请求不能超过5条");
            }

            return new
            {
                trans_content = new TransContent<TransSplitReqData>()
                {
                    TransReqDatas = new List<TransReqDatas<TransSplitReqData>>()
                    {
                        new TransReqDatas<TransSplitReqData>()
                        {
                            TransReqData = DataList
                        }
                    }
                    ,
                    TransHead = new TransHead
                    {
                        TransCount = DataList.Count(),
                        TransTotalMoney = DataList.Sum(x => x.TransMoney)
                    }
                }
            };
        }
    }
}