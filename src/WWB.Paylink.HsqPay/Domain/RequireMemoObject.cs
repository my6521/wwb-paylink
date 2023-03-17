namespace WWB.Paylink.HsqPay.Domain;

public abstract class RequireMemoObject<TMemo> : HsqPayObject
{
    /// <summary>
    /// 扩展信息
    /// </summary>
    /// <remarks>
    /// json格式
    /// </remarks>
    public string memo { get; set; }

    /// <summary>
    /// 设置Memo对象
    /// </summary>
    /// <param name="memoObject"></param>
    public virtual void SetMemo(TMemo memoObject)
    {
        memo = JsonConvert.SerializeObject(memoObject);
    }

    /// <summary>
    /// 获取对象
    /// </summary>
    /// <returns></returns>
    public TMemo GetMemo()
    {
        return JsonConvert.DeserializeObject<TMemo>(memo);
    }
}