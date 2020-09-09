using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class WEB_BRANCH
    {
        public decimal WEB_BRANCH_ID { get; set; }
        public decimal? WEB_COMPANY_ID { get; set; }
        public decimal? WEB_ZONE_ID { get; set; }
        public string NAMECN { get; set; }
        public string NAMEEN { get; set; }
        public string WEBSITE { get; set; }
        public string FEE_RATE { get; set; }
        public string GPS_ADDRESS { get; set; }
    }
}
