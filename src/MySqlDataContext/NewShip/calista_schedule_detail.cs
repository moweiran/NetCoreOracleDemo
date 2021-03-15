using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class calista_schedule_detail
    {
        public long CALISTA_SCHEDULE_DETAIL_ID { get; set; }
        public long CALISTA_SCHEDULE_ID { get; set; }
        public int SEQ_NO { get; set; }
        public string PORT_CODE { get; set; }
        public string PORT_NAME { get; set; }
        public string TRANSPORT_MODE { get; set; }
        public string SCH_VESSEL_NAME { get; set; }
        public string SCH_VOYAGE_NO { get; set; }
        public string SCH_SERVICE { get; set; }
        public string ARRIVAL_TIME { get; set; }
        public string DEPARTURE_TIME { get; set; }
        public string CY_CUTOFF_TIME { get; set; }
    }
}
