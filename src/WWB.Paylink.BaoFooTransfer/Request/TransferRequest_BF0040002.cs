using WWB.Paylink.BaoFooTransfer.Domain;
using WWB.Paylink.BaoFooTransfer.Domain.Request;
using WWB.Paylink.BaoFooTransfer.Response;

namespace WWB.Paylink.BaoFooTransfer.Request;

/// <summary>
/// 代付交易状态查询
/// </summary>
public class TransferRequest_BF0040002 : IBaofPayRequest<TransferResponse_BF0040002>
{
    private string contentType = HttpContentType.PostFormUrlencoded;
    private string requestUrl = "https://paytest.baofoo.com/baofoo-fopay/pay/BF0040002.do";
    private bool needEncrypt = true;

    public string RequestUrl => requestUrl;
    public string ContentType => contentType;
    public bool NeedEncrypt => needEncrypt;

    private TransContent<TransReqData_BF0040002> transContent;

    public virtual IDictionary<string, string> GetParameters(BaofPayOptions options)
    {
        var parameters = new Dictionary<string, string>
        {
            {"member_id", options.MchId},
            {"terminal_id", options.TerminalId},
            {"data_type", "json"},
            {"version", "4.0.0"}
        };

        return parameters;
    }

    public void PrimaryHandler(IDictionary<string, string> sortedTxtParams, BaofPayOptions options)
    {
        if (transContent == null) throw new ArgumentNullException(nameof(transContent));
        var signContent = JsonConvert.SerializeObject(new
        {
            trans_content = transContent
        });

        sortedTxtParams.Add(BaofPayConsts.SIGN_CONTENT, BaofPaySignature.Encrypt(signContent, options));
    }

    public void SetTransReqDatas(List<TransReqData_BF0040002> list)
    {
        if (list.Count > 5)
        {
            throw new BaofPayException("代付交易一次处理的请求不能超过5条");
        }

        transContent = new TransContent<TransReqData_BF0040002>()
        {
            trans_reqDatas = new List<TransReqDatas<TransReqData_BF0040002>>()
            {
                new TransReqDatas<TransReqData_BF0040002>()
                {
                    trans_reqData = list
                }
            }
        };
    }
}