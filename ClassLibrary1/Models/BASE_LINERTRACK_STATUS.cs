using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class BASE_LINERTRACK_STATUS
    {
        public string KEY_IDD { get; set; }
        public string F_KEY_ID { get; set; }
        public string BL_NO { get; set; }
        public string STATUS_CD { get; set; }
        public DateTime? STATUS_TIME { get; set; }
        public string STATUS_PLACE { get; set; }
        public string VEL_NAME { get; set; }
        public string VOY { get; set; }
        public string IS_EST { get; set; }
        public DateTime? UPDATE_TIME { get; set; }
        public DateTime? CREATE_TIME { get; set; }
    }
}
