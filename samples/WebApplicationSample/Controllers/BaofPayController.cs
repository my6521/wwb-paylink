using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WWB.Paylink.BaofPay;
using WWB.Paylink.BaofPay.Domain.Request;
using WWB.Paylink.BaofPay.Request;
using WWB.Paylink.BaofPay.Response;

namespace WebApplicationSample.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BaofPayController : ControllerBase
    {
        private readonly IOptions<BaofPayOptions> _optionsAccessor;
        private readonly IBaofPayClient _client;

        public BaofPayController(IOptions<BaofPayOptions> optionsAccessor, IBaofPayClient client)
        {
            _optionsAccessor = optionsAccessor;
            _client = client;
        }

        [HttpGet]
        public async Task<IActionResult> BF0040001()
        {
            var request = new TransferRequest_BF0040001();

            var reqList = new List<TransReqData_BF0040001>();

            reqList.Add(new TransReqData_BF0040001
            {
                trans_no = DateTime.Now.ToString("yyyyMMddHHmmss"),
                trans_money = "1",
                to_acc_name = "王文兵",
                to_acc_no = "6214921602437622",
                to_bank_name = "中国光大银行",
                to_pro_name = "四川省",
                trans_cnap = "",
                to_city_name = "成都市",
                to_acc_dept = "光华支行",
                trans_card_id = "510321198302092452",
                trans_mobile = "18981713541",
                trans_summary = "网银转账",
                trans_reserved = "生活消费"
            });
            reqList.Add(new TransReqData_BF0040001
            {
                trans_no = DateTime.Now.AddMinutes(1).ToString("yyyyMMddHHmmss"),
                trans_money = "2",
                to_acc_name = "王文兵",
                to_acc_no = "6214921602437622",
                to_bank_name = "中国光大银行",
                to_pro_name = "四川省",
                trans_cnap = "",
                to_city_name = "成都市",
                to_acc_dept = "光华支行",
                trans_card_id = "510321198302092452",
                trans_mobile = "18981713541",
                trans_summary = "网银转账",
                trans_reserved = "生活消费"
            });

            request.SetTransReqDatas(reqList);

            var response = await _client.ExecuteAsync<TransferResponse_BF0040001>(request, _optionsAccessor.Value);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> BF0040002(TransReqData_BF0040002 model)
        {
            var request = new TransferRequest_BF0040002();

            var reqList = new List<TransReqData_BF0040002>();
            reqList.Add(new TransReqData_BF0040002
            {
                trans_batchid = model.trans_batchid,
                trans_no = model.trans_no
            });

            request.SetTransReqDatas(reqList);

            var response = await _client.ExecuteAsync<TransferResponse_BF0040002>(request, _optionsAccessor.Value);
            if (response.trans_content.trans_head.return_code == "0000")
            {
            }

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> BF0040003(TransReqData_BF0040003 model)
        {
            var request = new TransferRequest_BF0040003();

            var BF0040003_ReqList = new List<TransReqData_BF0040003>();
            BF0040003_ReqList.Add(new TransReqData_BF0040003
            {
                trans_btime = model.trans_btime,
                trans_etime = model.trans_etime
            });

            request.SetTransReqDatas(BF0040003_ReqList);

            var response = await _client.ExecuteAsync<TransferResponse_BF0040003>(request, _optionsAccessor.Value);

            return Ok(response);
        }
    }
}