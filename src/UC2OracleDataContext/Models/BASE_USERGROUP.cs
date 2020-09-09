using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_USERGROUP
    {
        public BASE_USERGROUP()
        {
            BASE_USERGROUP_RIGHT = new HashSet<BASE_USERGROUP_RIGHT>();
        }

        public decimal USERGROUP_ID { get; set; }
        public decimal? COMPANY_ID { get; set; }
        public decimal? ORGANIZATION_ID { get; set; }
        public decimal PARENT_ID { get; set; }
        public decimal LAYER { get; set; }
        public string USERGROUP_CODE { get; set; }
        public string USERGROUP_NAME { get; set; }
        public string USERGROUP_REMARK { get; set; }
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

        public virtual ICollection<BASE_USERGROUP_RIGHT> BASE_USERGROUP_RIGHT { get; set; }
    }
}
