using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class CARGOTRACK_E_BK
    {
        public decimal CARGOTRACK_E_BK_ID { get; set; }
        public string TM_DATA_ID { get; set; }
        public string EXPRESS_CODE { get; set; }
        public string EXPRESS_NO { get; set; }
        public string STATUS { get; set; }
        public DateTime? CREATE_DATETIME { get; set; }
        public DateTime? MODIFY_DATETIME { get; set; }
        public string LAST_EVENT { get; set; }
        public string LAST_UPDATETIME { get; set; }
        public string TRACKINFO_JSONSTR { get; set; }
    }
}
