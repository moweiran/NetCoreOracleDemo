using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class WEB_COMPANY
    {
        public decimal WEB_COMPANY_ID { get; set; }
        public string NAMECN { get; set; }
        public string NAMEEN { get; set; }
        public string COMPANY_CODE { get; set; }
        public decimal? COMPANY_TYPE { get; set; }
        public decimal? SEQENCE { get; set; }
        public DateTime? MODIFY_DATETIME { get; set; }
    }
}
