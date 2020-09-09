using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_USERROLE
    {
        public BASE_USERROLE()
        {
            BASE_CROSS_ENTERPRISE = new HashSet<BASE_CROSS_ENTERPRISE>();
            BASE_USERROLE_RIGHT = new HashSet<BASE_USERROLE_RIGHT>();
            BASE_USER_RIGHT = new HashSet<BASE_USER_RIGHT>();
        }

        public decimal USERROLE_ID { get; set; }
        public decimal? COMPANY_ID { get; set; }
        public decimal? ORGANIZATION_ID { get; set; }
        public decimal PARENT_ID { get; set; }
        public string ROLE_NAME { get; set; }
        public string ROLE_RESTRICTION { get; set; }
        public string ROLE_REMARK { get; set; }
        public decimal ADMIN { get; set; }
        public decimal SEQUENCE { get; set; }
        public string SEQUENCE_STRING { get; set; }
        public decimal DELETE_MARK { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATE { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATE { get; set; }

        public virtual ICollection<BASE_CROSS_ENTERPRISE> BASE_CROSS_ENTERPRISE { get; set; }
        public virtual ICollection<BASE_USERROLE_RIGHT> BASE_USERROLE_RIGHT { get; set; }
        public virtual ICollection<BASE_USER_RIGHT> BASE_USER_RIGHT { get; set; }
    }
}
