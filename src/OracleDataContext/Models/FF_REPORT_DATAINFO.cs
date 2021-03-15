using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_REPORT_DATAINFO
    {
        public decimal FF_REPORT_DATAINFO_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal REPORT_TYPE { get; set; }
        public string REPORT_NAME { get; set; }
        public string REPORT_CONTENT { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_USER_NAME { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
        public bool? ISCREDITNOTE { get; set; }
        public decimal? LOA_TYPE { get; set; }
        public bool? IS_TAXPERCENT { get; set; }
    }
}
