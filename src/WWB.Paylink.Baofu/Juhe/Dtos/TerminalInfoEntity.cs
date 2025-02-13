namespace WWB.Paylink.Baofu.Juhe.Dtos
{
    /// <summary>
    /// 终端信息
    /// </summary>
    public class TerminalInfoEntity
    {
        public string location { get; set; }
        public string network_license { get; set; }
        public string device_type { get; set; }
        public string serial_num { get; set; }
        public string terminal_id { get; set; } ////终端设备的硬件序列号---支付宝，
        public string device_id { get; set; } ///-终端设备号----微信，
        public string encrypt_rand_num { get; set; }
        public string secret_text { get; set; }
        public string app_version { get; set; }
        public string device_ip { get; set; }
        public string mobile_country_cd { get; set; }
        public string mobile_net_num { get; set; }
        public string icc_id { get; set; }
        public string location_cd1 { get; set; }
        public string lbs_num1 { get; set; }
        public string lbs_signal1 { get; set; }
        public string location_cd2 { get; set; }
        public string lbs_num2 { get; set; }
        public string lbs_signal2 { get; set; }
        public string location_cd3 { get; set; }
        public string lbs_num3 { get; set; }
        public string lbs_signal3 { get; set; }
        public string telecom_sys_id { get; set; }
        public string telecom_net_id { get; set; }
        public string telecom_lbs { get; set; }
        public string telecom_lbs_signal { get; set; }
    }
}