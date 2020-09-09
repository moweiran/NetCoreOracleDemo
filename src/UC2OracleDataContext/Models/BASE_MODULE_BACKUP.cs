using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_MODULE_BACKUP
    {
        public decimal MODULE_ID { get; set; }
        public decimal APPLICATION_ID { get; set; }
        public string APPLICATION_CODE { get; set; }
        public string APPLICATION_NAME { get; set; }
        public decimal? PLATFORM { get; set; }
        public decimal PARENT_ID { get; set; }
        public string MODULE_CODE { get; set; }
        public string MODULE_NAME { get; set; }
        public decimal MODULE_TYPE { get; set; }
        public string MODULE_RIGHT_CODE { get; set; }
        public string NAVIGATE_URL { get; set; }
        public string QUERY_STRING { get; set; }
        public string DIRECTORY { get; set; }
        public string FILENAME { get; set; }
        public string ICON { get; set; }
        public string IMG { get; set; }
        public decimal? MODULE_LAYER { get; set; }
        public string VERSION { get; set; }
        public string INFORMATION { get; set; }
        public string REMARK { get; set; }
        public decimal SEQUENCE { get; set; }
        public string SEQUENCE_STRING { get; set; }
        public decimal DELETE_MARK { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATE { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public decimal? BUTTON_ID { get; set; }
    }
}
