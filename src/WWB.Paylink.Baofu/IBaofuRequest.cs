using System.Collections.Generic;

namespace WWB.Paylink.Baofu
{
    public interface IBaofuRequest<T> where T : BaseResponse
    {
        /// <summary>
        /// 获取请求地址
        /// </summary>
        /// <param name="debug"></param>
        /// <returns></returns>
        string GetRequestUrl(bool debug);

        /// <summary>
        /// 获取ContentType
        /// </summary>
        /// <returns></returns>
        string GetContentType();

        /// <summary>
        /// 处理数据
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        IDictionary<string, string> PrimaryHandler(BaofuOptions options);
    }
}