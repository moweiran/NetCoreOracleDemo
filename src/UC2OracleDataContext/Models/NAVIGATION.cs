using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class NAVIGATION
    {
        public decimal NAVIGATION_ID { get; set; }
        public decimal USER_ID { get; set; }
        public string NAVIGATION_NAME { get; set; }
        public string NAVIGATE_URL { get; set; }
        public string TARGET { get; set; }
        public string NAVIGATE_ICON { get; set; }
        public string NAVIGATE_REMARK { get; set; }
        public bool? Default { get; set; }
        public decimal SEQUENCE { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATE { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATE { get; set; }
    }
}
