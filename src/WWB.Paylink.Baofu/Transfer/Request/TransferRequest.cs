﻿using System.Collections.Generic;
using System.Linq;
using WWB.Paylink.Baofu.Transfer.Response;

namespace WWB.Paylink.Baofu.Transfer.Dtos
{
    /// <summary>
    /// 代付交易接口
    /// </summary>
    public class TransferRequest : BaseTransRequest, IBaofuRequest<BaseTransResponse<TransferResponse>>
    {
        /// <summary>
        /// 业务参数
        /// </summary>
        public List<TransReqData> DataList { get; set; } = new List<TransReqData>();

        public string GetRequestUrl(bool debug)
        {
            return debug ? "https://paytest.baofoo.com/baofoo-fopay/pay/BF0040001.do" : "https://public.baofoo.com/baofoo-fopay/pay/BF0040001.do";
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
                trans_content = new TransContent<TransReqData>()
                {
                    TransReqDatas = new List<TransReqDatas<TransReqData>>()
                    {
                        new TransReqDatas<TransReqData>()
                        {
                            TransReqData = DataList
                        }
                    }
                }
            };
        }
    }
}