using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class BASE_LINERTRACK
    {
        public string KEY_ID { get; set; }
        public string LOCAL_KEYID { get; set; }
        public string BL_PREFIX { get; set; }
        public string REFERENCE_NO { get; set; }
        public string BL_NO { get; set; }
        public string BKG_NO { get; set; }
        public string TRFS_NO { get; set; }
        public string BKGVOLUMN { get; set; }
        public string CARRIER_CD { get; set; }
        public string CARRIER { get; set; }
        public string CURRENT_NODE_PLACE { get; set; }
        public DateTime? CURRENT_NODE_DATE { get; set; }
        public string CURRENT_NODE { get; set; }
        public DateTime? END_DATE { get; set; }
        public DateTime? UPDATE_TIME { get; set; }
        public DateTime? CREATE_TIME { get; set; }
        public string POL { get; set; }
        public string DTP { get; set; }
        public string TERMINAL_CD { get; set; }
        public string TERMINAL_ { get; set; }
        public string DPTLOAD_ID { get; set; }
        public string VEL_NAME { get; set; }
        public string VOY { get; set; }
        public string DECLARATION_NO { get; set; }
    }
}
