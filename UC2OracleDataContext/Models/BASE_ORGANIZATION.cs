using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_ORGANIZATION
    {
        public BASE_ORGANIZATION()
        {
            BASE_CROSS_ENTERPRISE = new HashSet<BASE_CROSS_ENTERPRISE>();
            BASE_ORGANIZATION_RIGHT = new HashSet<BASE_ORGANIZATION_RIGHT>();
            BASE_STAFF_ORGANIZE = new HashSet<BASE_STAFF_ORGANIZE>();
        }

        public decimal ORGANIZATION_ID { get; set; }
        public decimal? COMPANY_ID { get; set; }
        public string ORGANIZATION_CODE { get; set; }
        public string ORGANIZATION_NAME { get; set; }
        public string ORGANIZATION_INNER_PHONE { get; set; }
        public string ORGANIZATION_OUTER_PHONE { get; set; }
        public decimal ORGANIZATION_MANAGER { get; set; }
        public decimal? ORGANIZATION_ASSISTANT_MANAGER { get; set; }
        public string ORGANIZATION_FAX { get; set; }
        public string ORGANIZATION_POSTCODE { get; set; }
        public string ORGANIZATION_ADDRESS { get; set; }
        public string ORGANIZATION_EMAIL { get; set; }
        public decimal PARENT_ID { get; set; }
        public decimal LAYER { get; set; }
        public string ORGANIZATION_REMARK { get; set; }
        public decimal? USERS { get; set; }
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
        public virtual ICollection<BASE_ORGANIZATION_RIGHT> BASE_ORGANIZATION_RIGHT { get; set; }
        public virtual ICollection<BASE_STAFF_ORGANIZE> BASE_STAFF_ORGANIZE { get; set; }
    }
}
