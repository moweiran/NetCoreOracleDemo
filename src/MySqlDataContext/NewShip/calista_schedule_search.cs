using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class calista_schedule_search
    {
        public long CALISTA_SCHEDULE_SEARCH_ID { get; set; }
        public long POL_ID { get; set; }
        public string POL_CODE { get; set; }
        public long POD_ID { get; set; }
        public string POD_CODE { get; set; }
        public int? TIMES { get; set; }
        public bool? ISOCCUPIED { get; set; }
        public long RECEIPT_ID { get; set; }
        public long DELIVERY_ID { get; set; }
    }
}
