using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class BASE_SEASHIPPING_SUB
    {
        public decimal BASE_SEASHIPPING_SUB_ID { get; set; }
        public string BL_NO { get; set; }
        public string CARRIER_CODE { get; set; }
        public string POL_CODE { get; set; }
        public string KEYID { get; set; }
        public decimal SUB_STATUS { get; set; }
        public decimal DOWNLOAD_STATUS { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public string ERROR_MESSAGE { get; set; }
    }
}
