﻿using System.Collections.Generic;
using System.Linq;
using WWB.Paylink.BaoFooTransfer.Domain;
using WWB.Paylink.BaoFooTransfer.Domain.Request;
using WWB.Paylink.BaoFooTransfer.Response;

namespace WWB.Paylink.BaoFooTransfer.Request
{
    /// <summary>
    /// 代付交易状态查询
    /// </summary>
    public class TransferQueryRequest : AbstractRequest, IBaoFooTransRequest<TransferQueryResponse>
    {
        /// <summary>
        /// 业务参数
        /// </summary>
        public List<TransQueryReqData> DataList { get; set; } = new List<TransQueryReqData>();

        public string GetRequestUrl(bool debug)
        {
            return debug ? "https://paytest.baofoo.com/baofoo-fopay/pay/BF0040002.do" : "https://public.baofoo.com/baofoo-fopay/pay/BF0040002.do";
        }

        public IDictionary<string, string> PrimaryHandler(BaoFooTransOptions options)
        {
            if (!DataList.Any())
            {
                throw new BaoFooTransException("代付交易至少需要一条交易数据");
            }

            if (DataList.Count > 5)
            {
                throw new BaoFooTransException("代付交易一次处理的请求不能超过5条");
            }

            var dataContent = BuidEncryptData();

            return base.PrimaryHandler<object>(dataContent, options);
        }

        private object BuidEncryptData()
        {
            return new
            {
                trans_content = new TransContent<TransQueryReqData>()
                {
                    TransReqDatas = new List<TransReqDatas<TransQueryReqData>>()
                    {
                        new TransReqDatas<TransQueryReqData>()
                        {
                            TransReqData = DataList
                        }
                    }
                }
            };
        }
    }
}