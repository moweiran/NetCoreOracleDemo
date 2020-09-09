using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_ASYNC_RATE
    {
        public decimal FF_ASYNC_RATE_ID { get; set; }
        public decimal FF_RATE_ID { get; set; }
        public decimal ASYNC_STATUS { get; set; }
        public DateTime? EXEC_DATE { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public DateTime RATE_UPDATEDATE { get; set; }
    }
}
