using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_APPLICATION_ROLES
    {
        public decimal APPLICATION_ROLE_ID { get; set; }
        public decimal APPLICATION_ID { get; set; }
        public string APPLICATION_KEY { get; set; }
        public string APPLICATION_CODE { get; set; }
        public string APPLICATION_NAME { get; set; }
        public decimal PLATFORM { get; set; }
        public decimal PARENT_ID { get; set; }
        public string ROLE_NAME { get; set; }
        public string ROLE_RESTRICTION { get; set; }
        public string ROLE_REMARK { get; set; }
        public decimal? APPLAY_TO { get; set; }
        public decimal SEQUENCE { get; set; }
        public string SEQUENCE_STRING { get; set; }
        public decimal DELETE_MARK { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATE { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATE { get; set; }
    }
}
