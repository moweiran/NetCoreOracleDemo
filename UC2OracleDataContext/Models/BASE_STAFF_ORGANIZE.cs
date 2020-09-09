using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_STAFF_ORGANIZE
    {
        public decimal STAFF_ORGANIZE_ID { get; set; }
        public decimal COMPANY_ID { get; set; }
        public decimal ORGANIZATION_ID { get; set; }
        public decimal USER_ID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }

        public virtual BASE_ORGANIZATION ORGANIZATION_ { get; set; }
    }
}
