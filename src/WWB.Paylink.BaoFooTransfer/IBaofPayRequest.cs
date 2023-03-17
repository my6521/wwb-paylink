namespace WWB.Paylink.BaoFooTransfer;

public interface IBaofPayRequest<T> where T : BaofPayResponse
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
    /// 获取是否需要验签
    /// </summary>
    /// <returns>是否需要验签</returns>
    bool NeedEncrypt { get; }

    /// <summary>
    /// 获取文本参数字典
    /// </summary>
    /// <returns>文本参数字典</returns>
    IDictionary<string, string> GetParameters(BaofPayOptions options);

    /// <summary>
    /// 参数处理器
    /// </summary>
    /// <param name="sortedTxtParams">排序文本参数</param>
    /// <param name="options">配置选项</param>
    void PrimaryHandler(IDictionary<string, string> sortedTxtParams, BaofPayOptions options);
}