namespace WWB.Paylink.BaoFooTransfer
{
    public abstract class BaseResponse
    {
        /// <summary>
        /// 原始内容
        /// </summary>
        [JsonIgnore]
        internal string Body { get; set; }

        internal virtual void Execute()
        {
        }
    }
}