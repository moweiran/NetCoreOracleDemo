using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class calista_schedule
    {
        public long CALISTA_SCHEDULE_ID { get; set; }
        public long CALISTA_SCHEDULE_SEARCH_ID { get; set; }
        public int? TRANSIT { get; set; }
        public string VESSEL_NAME { get; set; }
        public string VOYAGE_NO { get; set; }
        public string SERVICE { get; set; }
        public string CARRIER { get; set; }
        public string CARRIERCODE { get; set; }
        public long? POL_ID { get; set; }
        public string POL_CODE { get; set; }
        public string POL_ETA { get; set; }
        public string POL_ETD { get; set; }
        public long? POD_ID { get; set; }
        public string POD_CODE { get; set; }
        public string POD_ETA { get; set; }
        public string POD_ETD { get; set; }
        public string CY_CUTOFF { get; set; }
        public string VOYAGE_ID { get; set; }
        public string CARRIER_PARTY_ID { get; set; }
        public int? RANK_EARLIEST { get; set; }
        public int? RANK_FASTEST { get; set; }
    }
}
