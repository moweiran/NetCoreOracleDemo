using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class CUS_DECLAR_SUB
    {
        public decimal CUS_DECLAR_SUB_ID { get; set; }
        public string DECLARATIONNO { get; set; }
        public decimal DOWNLOAD_STATUS { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
    }
}
