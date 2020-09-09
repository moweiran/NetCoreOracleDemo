using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_SYNC_RATE_CUSTOMER
    {
        public decimal SYNC_RATE_CUSTOMER_ID { get; set; }
        public decimal FF_RATE_LIST_ID { get; set; }
        public decimal SYNC_STATUS { get; set; }
        public DateTime? SYNC_DATE { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public DateTime RATE_UPDATEDATE { get; set; }
    }
}
