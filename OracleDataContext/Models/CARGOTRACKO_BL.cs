using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class CARGOTRACKO_BL
    {
        public string KEY_ID { get; set; }
        public string BL_PREFIX { get; set; }
        public string BKG_NO { get; set; }
        public string BL_NO { get; set; }
        public string CARRIER_CD { get; set; }
        public string CARRIER { get; set; }
        public string PLR_CD { get; set; }
        public string PLR { get; set; }
        public string POL_CD { get; set; }
        public string POL { get; set; }
        public string DTP_CD { get; set; }
        public string DTP { get; set; }
        public string PLD_CD { get; set; }
        public string PLD { get; set; }
        public string BKG_VOLUMN { get; set; }
        public string VSL_NAME { get; set; }
        public string VOY { get; set; }
        public DateTime? UPDATE_TIME { get; set; }
        public DateTime? CREATE_TIME { get; set; }
        public string BL_ID { get; set; }
        public string CURRENT_NODE { get; set; }
        public DateTime? CURRENT_NODE_TIME { get; set; }
        public string CURRENT_NODE_PLACE { get; set; }
        public string SCHEDULELISTJSONSTR { get; set; }
        public string LOCALKEYID { get; set; }
    }
}
