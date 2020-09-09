using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_USERINFO_USERGROUP
    {
        public decimal USERINFO_USERGROUP_ID { get; set; }
        public decimal? USER_ID { get; set; }
        public decimal? USERGROUP_ID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
    }
}
