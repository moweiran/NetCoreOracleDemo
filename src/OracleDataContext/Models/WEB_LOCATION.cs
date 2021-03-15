using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class WEB_LOCATION
    {
        public decimal WEB_LOCATION_ID { get; set; }
        public decimal? WEB_ZONE_ID { get; set; }
        public string NAMECN { get; set; }
        public string NAMEEN { get; set; }
        public string BELONG_COMPANY_NAMECN { get; set; }
        public string BELONG_COMPANY_NAMEEN { get; set; }
        public string ADDRESS { get; set; }
        public string WEBSITE { get; set; }
        public decimal? LOCATION_TYPE { get; set; }
        public decimal? SEQENCE { get; set; }
        public DateTime? MODIFY_DATETIME { get; set; }
    }
}
