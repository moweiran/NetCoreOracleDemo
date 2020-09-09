using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BASE_COMPANY_CHECK
    {
        public decimal COMPANY_CHECK_ID { get; set; }
        public decimal? COMPANY_ID { get; set; }
        public string COMPANY_SHORTNAME { get; set; }
        public decimal? CHECK_RESULT { get; set; }
        public DateTime? CHECK_DATE { get; set; }
        public decimal? CHECK_USERID { get; set; }
        public string CHECK_FULLNAME { get; set; }
        public string CHECK_OPINION { get; set; }
    }
}
