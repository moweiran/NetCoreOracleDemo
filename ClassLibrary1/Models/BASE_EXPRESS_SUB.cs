using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class BASE_EXPRESS_SUB
    {
        public decimal BASE_EXPRESS_SUB_ID { get; set; }
        public string EXPRESS_CODE { get; set; }
        public string EXPRESS_NO { get; set; }
        public decimal SUB_STATUS { get; set; }
        public decimal DOWNLOAD_STATUS { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
    }
}
