namespace WWB.Paylink.BaoFooTransfer.Request
{ /// <summary>
  /// 代付交易退款查询
  /// </summary>
    public class RefundQueryRequest : AbstractRequest, IRequest<RefundQueryResponse>
    {
        /// <summary>
        /// 业务参数
        /// </summary>
        public RefundQueryReqData ReqData { get; set; }

        public string GetRequestUrl(bool debug)
        {
            return debug ? "https://paytest.baofoo.com/baofoo-fopay/pay/BF0040003.do" : "";
        }

        public IDictionary<string, string> PrimaryHandler(BaoFooTransOptions options)
        {
            var dataContent = BuidEncryptData();

            return base.PrimaryHandler<object>(dataContent, options);
        }

        private object BuidEncryptData()
        {
            return new
            {
                trans_content = new TransContent<RefundQueryReqData>()
                {
                    trans_reqDatas = new List<TransReqDatas<RefundQueryReqData>>()
                {
                    new TransReqDatas<RefundQueryReqData>()
                    {
                        trans_reqData = new List<RefundQueryReqData>{ ReqData }
                    }
                }
                }
            };
        }
    }
}