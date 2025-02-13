namespace WWB.Paylink.Baofu.Juhe
{
    /// <summary>
    /// 分账返回状态
    /// </summary>
    public class ShareState
    {
        /// <summary>
        /// 分账成功
        /// </summary>
        public const string SUCCESS = "SUCCESS";

        /// <summary>
        /// 分账处理中
        /// </summary>
        public const string PROCESSING = "PROCESSING";

        /// <summary>
        /// 取消分账
        /// </summary>
        public const string CANCELED = "CANCELED";

        /// <summary>
        /// 分账请求异常
        /// </summary>
        public const string ABNORMAL = "ABNORMAL";
    }
}