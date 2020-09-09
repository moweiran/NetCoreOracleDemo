using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class MV_PORT_COUNTRY
    {
        public decimal BASE_COUNTRY_ID { get; set; }
        public string COUNTRY_NAME_EN { get; set; }
        public string COUNTRY_NAME_CN { get; set; }
        public decimal? TOTAL_COUNT { get; set; }
    }
}
