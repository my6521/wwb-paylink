﻿namespace WWB.Paylink.HsqPay.Request;

/// <summary>
/// 交易查询
/// </summary>
public class TransactionQueryRequest : IHsqPayRequest<TransactionQueryResponse>
{
    private string method = "POLYMERIZE_QUERY";
    private string version = "1.0";
    private string format = "JSON";
    private string signType = HsqPaySignType.RSA2;
    private string contentType = HttpContentType.PostFormUrlencoded;
    private string requestUrl = "https://api.huishouqian.com/api/acquiring";
    private bool needEncrypt = true;

    private HsqPayObject bizModel;

    public string ContentType => contentType;
    public string RequestUrl => requestUrl;
    public string SignType => signType;
    public bool NeedCheckSign => needEncrypt;

    public HsqPayObject GetBizModel()
    {
        return this.bizModel;
    }

    public void SetBizModel(HsqPayObject bizModel)
    {
        this.bizModel = bizModel;
    }

    public IDictionary<string, string> GetParameters(HsqPayOptions options)
    {
        var parameters = new Dictionary<string, string>
        {
            {"method", method},
            {"version", version},
            {"format", format},
            {"merchantNo", options.MchId},
            {"signType", signType}
        };

        return parameters;
    }
}