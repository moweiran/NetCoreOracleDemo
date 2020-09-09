using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_COMPANY_ROLE
    {
        public decimal COMPANY_ROLE_ID { get; set; }
        public decimal APPLICATION_ID { get; set; }
        public string APPLICATION_NAME { get; set; }
        public decimal? APPLICATION_ROLE_ID { get; set; }
        public string ROLE_NAME { get; set; }
        public decimal PLATFORM { get; set; }
        public string PLATFORM_NAME { get; set; }
        public decimal? COMPANY_ID { get; set; }
        public decimal? DELETE_MARK { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime? MODIFY_DATE { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATE { get; set; }

        public virtual BASE_COMPANY COMPANY_ { get; set; }
    }
}
