using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_CROSS_ENTERPRISE
    {
        public decimal CROSS_ENTERPRISE_ID { get; set; }
        public decimal APPLICATION_ID { get; set; }
        public string APPLICATION_NAME { get; set; }
        public decimal COMPANY_ID { get; set; }
        public decimal ORGANIZATION_ID { get; set; }
        public decimal USERROLE_ID { get; set; }
        public decimal USERGROUP_ID { get; set; }
        public decimal USER_ID { get; set; }
        public string REMARK { get; set; }
        public string COMPANYS { get; set; }
        public bool? STATUS { get; set; }
        public decimal DELETE_MARK { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATE { get; set; }

        public virtual BASE_ORGANIZATION ORGANIZATION_ { get; set; }
        public virtual BASE_USERROLE USERROLE_ { get; set; }
    }
}
