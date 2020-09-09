using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class USER_PERMISSION_PAGEBUTTON
    {
        public decimal USER_PERMISSION_PAGEBUTTON_ID { get; set; }
        public decimal USER_PERMISSION_PAGE_ID { get; set; }
        public decimal APPLICATION_ID { get; set; }
        public string APPLICATION_NAME { get; set; }
        public decimal USER_ID { get; set; }
        public decimal ORGANIZATION_RIGHT_ID { get; set; }
        public decimal USERGROUP_RIGHT_ID { get; set; }
        public decimal USERROLE_RIGHT_ID { get; set; }
        public decimal USER_RIGHT_ID { get; set; }
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
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATE { get; set; }
    }
}
