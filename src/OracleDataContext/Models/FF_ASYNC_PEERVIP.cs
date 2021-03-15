using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_ASYNC_PEERVIP
    {
        public decimal FF_ASYNC_PEERVIP_ID { get; set; }
        public decimal FF_PEERVIP_RULE_ID { get; set; }
        public decimal ASYNC_STATUS { get; set; }
        public DateTime? EXEC_DATE { get; set; }
        public DateTime CREATE_DATE { get; set; }
    }
}
