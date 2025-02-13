namespace WWB.Paylink.Baofu.Juhe.Dtos
{
    /// <summary>
    /// 风控信息
    /// </summary>
    public class RiskInfoEntity
    {
        /// <summary>
        /// 付款用户ip地址
        /// </summary>
        public string clientIp { get; set; }

        /// <summary>
        /// 包含经度和纬度，英文逗号分隔
        /// </summary>
        public string locationPoint { get; set; }
    }
}