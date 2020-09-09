using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BASE_AIRSHIPPING_SUB
    {
        public decimal BASE_AIRSHIPPING_SUB_ID { get; set; }
        public string KEYID { get; set; }
        public decimal SUB_STATUS { get; set; }
        public decimal DOWNLOAD_STATUS { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public string AWBNO { get; set; }
        public string AWBNO2 { get; set; }
        public string AWBNO3 { get; set; }
        public string CARRIERCD { get; set; }
        public string CARRIERCD2 { get; set; }
        public string CARRIERCD3 { get; set; }
        public decimal TYPE { get; set; }
    }
}
