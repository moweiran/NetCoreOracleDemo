using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_RAILWAY_PRICE_LEV_DET
    {
        public decimal BASE_RAIL_PRICE_LEV_DET_ID { get; set; }
        public decimal BASE_RAIL_PRICE_LEV_ID { get; set; }
        public decimal MINNUM { get; set; }
        public decimal MAXMUM { get; set; }
        public decimal ISUNRESTRICTED { get; set; }
        public string REMARK { get; set; }

        public virtual BASE_RAILWAY_PRICE_LEVEL BASE_RAIL_PRICE_LEV_ { get; set; }
    }
}
