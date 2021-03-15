using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class BASE_COMPANY_CREDITREPORT
    {
        public decimal BASE_COMPANY_CREDITREPORT_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string REPORT_DATE { get; set; }
        public string CREDIT_CLASS { get; set; }
        public decimal? PUBLIC_CLASS { get; set; }
        public string REPORT_SUBJECT { get; set; }
        public string REPORT_CONTENT { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
    }
}
