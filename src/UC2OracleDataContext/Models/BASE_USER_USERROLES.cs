using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_USER_USERROLES
    {
        public decimal USER_USERROLE_ID { get; set; }
        public decimal? USERROLE_ID { get; set; }
        public decimal? USER_ID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
    }
}
