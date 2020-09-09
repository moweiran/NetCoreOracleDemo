using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BASE_COMPANY_AUTHORITY
    {
        public decimal BASE_COMPANY_AUTHORITY_ID { get; set; }
        public decimal FF_ID { get; set; }
        public bool? IS_DIRECTCUSTOMER_MODE { get; set; }
        public bool? IS_WEBSITE_MODE { get; set; }
        public bool? IS_OPERATION_MODE { get; set; }
        public bool? IS_MARKETING_MODE { get; set; }
        public bool? IS_FINANCE_MODE { get; set; }
        public bool? IS_ROLE_MODE { get; set; }
        public bool? IS_TRAILER_MODE { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
