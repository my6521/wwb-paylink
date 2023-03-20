using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WWB.Paylink.BaoFooTransfer;
using WWB.Paylink.BaoFooTransfer.Domain.Request;
using WWB.Paylink.BaoFooTransfer.Request;
using WWB.Paylink.BaoFooTransfer.Response;

namespace WebApplicationSample.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TransferController : ControllerBase
    {
        private readonly IOptions<BaoFooTransOptions> _optionsAccessor;
        private readonly IBaoFooTransClient _client;

        public TransferController(IOptions<BaoFooTransOptions> optionsAccessor, IBaoFooTransClient client)
        {
            _optionsAccessor = optionsAccessor;
            _client = client;
        }

        [HttpGet]
        public async Task<IActionResult> BF0040001()
        {
            var request = new TransferRequest();

            var reqList = new List<TransReqData>();

            reqList.Add(new TransReqData
            {
                trans_no = DateTime.Now.ToString("yyyyMMddHHmmss"),
                trans_money = 1.20m,
                to_acc_name = "",
                to_acc_no = "",
                to_bank_name = "中国光大银行",
                to_pro_name = "四川省",
                trans_cnap = "",
                to_city_name = "成都市",
                to_acc_dept = "光华支行",
                trans_card_id = "",
                trans_mobile = "",
                trans_summary = "网银转账",
                trans_reserved = "生活消费"
            });

            request.DataList = reqList;

            var response = await _client.ExecuteAsync<TransferResponse>(request, _optionsAccessor.Value);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> BF0040002(TransQueryReqData model)
        {
            var request = new TransferQueryRequest();

            var reqList = new List<TransQueryReqData>();
            reqList.Add(new TransQueryReqData
            {
                trans_batchid = model.trans_batchid,
                trans_no = model.trans_no
            });

            request.DataList = reqList;

            var response = await _client.ExecuteAsync<TransferQueryResponse>(request, _optionsAccessor.Value);
            if (response.trans_content.trans_head.return_code == "0000")
            {
            }

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> BF0040003(RefundQueryReqData model)
        {
            var request = new RefundQueryRequest();

            request.ReqData = new RefundQueryReqData
            {
                trans_btime = model.trans_btime,
                trans_etime = model.trans_etime
            };

            var response = await _client.ExecuteAsync<RefundQueryResponse>(request, _optionsAccessor.Value);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> BF0040004()
        {
            var request = new TransferSplitRequest();

            var reqList = new List<TransSplitReqData>();

            reqList.Add(new TransSplitReqData
            {
                trans_no = DateTime.Now.ToString("yyyyMMddHHmmss"),
                trans_money = 1m,
                to_acc_name = "",
                to_acc_no = "",
                to_bank_name = "中国光大银行",
                to_pro_name = "四川省",
                to_city_name = "成都市",
                to_acc_dept = "光华支行",
                trans_card_id = "",
                trans_mobile = "",
                trans_summary = "网银转账",
                trans_reserved = "生活消费"
            });

            request.DataList = reqList;

            var response = await _client.ExecuteAsync<TransferSplitResponse>(request, _optionsAccessor.Value);

            return Ok(response);
        }
    }
}