namespace WWB.Paylink.HsqPay;

public interface IHsqPayRequest<T> where T : HsqPayResponse
{
    /// <summary>
    ///
    /// </summary>
    /// <returns></returns>
    string ContentType { get; }

    /// <summary>
    /// 获取请求接口地址
    /// </summary>
    /// <returns>接口地址</returns>
    string RequestUrl { get; }

    /// <summary>
    /// 获取签名
    /// </summary>
    /// <returns></returns>
    string SignType { get; }

    /// <summary>
    /// 获取是否需要验签
    /// </summary>
    /// <returns>是否需要验签</returns>
    bool NeedCheckSign { get; }

    /// <summary>
    /// 获取文本参数字典
    /// </summary>
    /// <returns>文本参数字典</returns>
    IDictionary<string, string> GetParameters(HsqPayOptions options);

    /// <summary>
    /// 获取BizModel
    /// </summary>
    HsqPayObject GetBizModel();

    /// <summary>
    /// 设置BizModel
    /// </summary>
    /// <param name="bizModel"></param>
    void SetBizModel(HsqPayObject bizModel);
}