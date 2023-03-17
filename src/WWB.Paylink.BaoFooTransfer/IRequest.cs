namespace WWB.Paylink.BaoFooTransfer
{
    public interface IRequest<T> where T : BaseResponse
    {
        /// <summary>
        /// 获取请求地址
        /// </summary>
        /// <param name="debug"></param>
        /// <returns></returns>
        string GetRequestUrl(bool debug);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        string GetContentType();

        /// <summary>
        /// 处理
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        IDictionary<string, string> PrimaryHandler(BaoFooTransOptions options);
    }
}