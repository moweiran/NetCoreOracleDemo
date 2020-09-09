using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_TRAIL_PRICE_LEV_DET
    {
        public decimal BASE_TRAI_PRICE_LEVEL_DET_ID { get; set; }
        public decimal BASE_TRAI_PRICE_LEVEL_ID { get; set; }
        public decimal MINNUM { get; set; }
        public decimal MAXMUM { get; set; }
        public decimal ISUNRESTRICTED { get; set; }
        public string REMARK { get; set; }

        public virtual BASE_TRAILER_PRICE_LEVEL BASE_TRAI_PRICE_LEVEL_ { get; set; }
    }
}
