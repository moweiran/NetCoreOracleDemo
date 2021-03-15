using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class BASE_NOTICE
    {
        public decimal NOTICE_ID { get; set; }
        public decimal NOTICE_SYSTEM { get; set; }
        public decimal NOTICE_TYPE { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public string NOTICE_CONTENT_CN { get; set; }
        public string NOTICE_CONTENT_EN { get; set; }
        public bool? DELETE_MARK { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public string CREATE_USERNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
