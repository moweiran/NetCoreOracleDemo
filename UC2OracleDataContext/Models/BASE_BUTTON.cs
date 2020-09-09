using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_BUTTON
    {
        public decimal BUTTON_ID { get; set; }
        public string BUTTON_CODE { get; set; }
        public string BUTTON_NAME { get; set; }
        public string BUTTON_TITLE { get; set; }
        public decimal BUTTON_TYPE { get; set; }
        public string BUTTON_ICON { get; set; }
        public string BUTTON_IMG { get; set; }
        public string BUTTON_EVENT { get; set; }
        public string BUTTON_METHOD { get; set; }
        public string BUTTON_REMARK { get; set; }
        public decimal SEQUENCE { get; set; }
        public decimal DELETE_MARK { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATE { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATE { get; set; }
    }
}
