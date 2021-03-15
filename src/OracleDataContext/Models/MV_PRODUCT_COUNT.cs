using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class MV_PRODUCT_COUNT
    {
        public decimal FF_ID { get; set; }
        public decimal CARRIER_ID { get; set; }
        public decimal ROUTE_ID { get; set; }
        public string POL_CODE { get; set; }
        public decimal? TOTAL_COUNT { get; set; }
    }
}
