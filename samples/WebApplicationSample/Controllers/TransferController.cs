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
                TransNo = DateTime.Now.ToString("yyyyMMddHHmmss"),
                TransMoney = 1.20m,
                ToAccName = "",
                ToAccNo = "",
                ToBankName = "中国光大银行",
                ToProName = "四川省",
                TransCnap = "",
                ToCityName = "成都市",
                ToAccDept = "光华支行",
                TransCardId = "",
                TransMobile = "",
                TransSummary = "网银转账",
                TransReserved = "生活消费"
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
                TransBatchId = model.TransBatchId,
                TransNo = model.TransNo
            });

            request.DataList = reqList;

            var response = await _client.ExecuteAsync<TransferQueryResponse>(request, _optionsAccessor.Value);
            if (response.TransContent.TransHead.IsSuccess)
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
                TransBeginTime = model.TransBeginTime,
                TransEndTime = model.TransEndTime
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
                TransNo = DateTime.Now.ToString("yyyyMMddHHmmss"),
                TransMoney = 1m,
                ToAccName = "",
                ToAccNo = "",
                ToBankName = "中国光大银行",
                ToProName = "四川省",
                ToCityName = "成都市",
                ToAccDept = "光华支行",
                TransCardId = "",
                TransMobile = "",
                TransSummary = "网银转账",
                TransReserved = "生活消费"
            });

            request.DataList = reqList;

            var response = await _client.ExecuteAsync<TransferSplitResponse>(request, _optionsAccessor.Value);

            return Ok(response);
        }
    }
}