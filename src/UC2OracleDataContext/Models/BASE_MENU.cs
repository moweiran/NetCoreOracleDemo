using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_MENU
    {
        public BASE_MENU()
        {
            BASE_ORGANIZATION_RIGHT = new HashSet<BASE_ORGANIZATION_RIGHT>();
            BASE_USERGROUP_RIGHT = new HashSet<BASE_USERGROUP_RIGHT>();
            BASE_USERROLE_RIGHT = new HashSet<BASE_USERROLE_RIGHT>();
        }

        public decimal MENU_ID { get; set; }
        public decimal? APPLICATION_ROLE_ID { get; set; }
        public decimal? APPLICATION_ROLE_RIGHT_ID { get; set; }
        public decimal APPLICATION_ID { get; set; }
        public string APPLICATION_KEY { get; set; }
        public string APPLICATION_CODE { get; set; }
        public string APPLICATION_NAME { get; set; }
        public decimal PLATFORM { get; set; }
        public decimal MODULE_ID { get; set; }
        public string MODULE_CODE { get; set; }
        public decimal PARENT_ID { get; set; }
        public string MENU_NAME { get; set; }
        public string MENU_TITLE { get; set; }
        public string MENU_CODE { get; set; }
        public string MENU_ICON { get; set; }
        public string MENU_IMG { get; set; }
        public decimal MENU_TYPE { get; set; }
        public decimal MENU_CLASS { get; set; }
        public string NAVIGATE_URL { get; set; }
        public string QUERY_STRING { get; set; }
        public string DIRECTORY { get; set; }
        public string FILENAME { get; set; }
        public string TARGET { get; set; }
        public decimal MENU_LAYER { get; set; }
        public decimal BUTTONS { get; set; }
        public decimal BUTTON_ID { get; set; }
        public decimal BUTTON_TYPE { get; set; }
        public string BUTTON_NAME { get; set; }
        public string BUTTON_TITLE { get; set; }
        public string BUTTON_ICON { get; set; }
        public string BUTTON_IMG { get; set; }
        public string BUTTON_CODE { get; set; }
        public string BUTTON_EVENT { get; set; }
        public string BUTTON_METHOD { get; set; }
        public decimal SEQUENCE { get; set; }
        public string SEQUENCE_STRING { get; set; }
        public decimal DELETE_MARK { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATE { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATE { get; set; }

        public virtual ICollection<BASE_ORGANIZATION_RIGHT> BASE_ORGANIZATION_RIGHT { get; set; }
        public virtual ICollection<BASE_USERGROUP_RIGHT> BASE_USERGROUP_RIGHT { get; set; }
        public virtual ICollection<BASE_USERROLE_RIGHT> BASE_USERROLE_RIGHT { get; set; }
    }
}
