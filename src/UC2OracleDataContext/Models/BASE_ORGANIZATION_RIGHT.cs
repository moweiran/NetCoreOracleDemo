using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_ORGANIZATION_RIGHT
    {
        public BASE_ORGANIZATION_RIGHT()
        {
            BASE_USERGROUP_RIGHT = new HashSet<BASE_USERGROUP_RIGHT>();
            BASE_USERROLE_RIGHT = new HashSet<BASE_USERROLE_RIGHT>();
            BASE_USER_RIGHT = new HashSet<BASE_USER_RIGHT>();
        }

        public decimal ORGANIZATION_RIGHT_ID { get; set; }
        public decimal ORGANIZATION_ID { get; set; }
        public decimal APPLICATION_ID { get; set; }
        public string APPLICATION_NAME { get; set; }
        public decimal PLATFORM { get; set; }
        public decimal APPLICATION_ROLE_ID { get; set; }
        public decimal? USERGROUP_RIGHT_ID { get; set; }
        public decimal? USERROLE_RIGHT_ID { get; set; }
        public decimal? USER_RIGHT_ID { get; set; }
        public decimal? MENU_ID { get; set; }
        public decimal PERMISSION_TYPE { get; set; }
        public decimal MODULE_ID { get; set; }
        public decimal? BUTTON_ID { get; set; }
        public decimal AUTHORIZE { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATE { get; set; }

        public virtual BASE_MENU MENU_ { get; set; }
        public virtual BASE_ORGANIZATION ORGANIZATION_ { get; set; }
        public virtual ICollection<BASE_USERGROUP_RIGHT> BASE_USERGROUP_RIGHT { get; set; }
        public virtual ICollection<BASE_USERROLE_RIGHT> BASE_USERROLE_RIGHT { get; set; }
        public virtual ICollection<BASE_USER_RIGHT> BASE_USER_RIGHT { get; set; }
    }
}
