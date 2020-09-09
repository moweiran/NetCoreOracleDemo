using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class CARGOTRACKO_CONTAINER_STATUS
    {
        public string KEY_ID { get; set; }
        public string C_KEY_ID { get; set; }
        public string STATUS { get; set; }
        public string STATE_DESC { get; set; }
        public string VSLVOY { get; set; }
        public string VSL_NAME { get; set; }
        public string VOY { get; set; }
        public DateTime? EVENT_TIME { get; set; }
        public string STATION { get; set; }
        public string TRANSPORTATION { get; set; }
        public string IS_CODE { get; set; }
        public string IS_EST { get; set; }
        public DateTime? UPDATE_TIME { get; set; }
    }
}
