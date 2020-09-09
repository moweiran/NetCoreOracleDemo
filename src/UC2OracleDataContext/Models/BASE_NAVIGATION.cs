using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_NAVIGATION
    {
        public decimal NAVIGATION_ID { get; set; }
        public decimal USER_ID { get; set; }
        public string NAVIGATION_NAME { get; set; }
        public string NAVIGATE_URL { get; set; }
        public string TARGET { get; set; }
        public string ICON { get; set; }
        public string REMAK { get; set; }
        public decimal? SEQUENCE { get; set; }
        public string SEQUENCE_STRING { get; set; }
    }
}
