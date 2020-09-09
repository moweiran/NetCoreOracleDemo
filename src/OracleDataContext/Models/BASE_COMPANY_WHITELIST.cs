using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BASE_COMPANY_WHITELIST
    {
        public decimal BASE_COMPANY_WHITELIST_ID { get; set; }
        public decimal COMPANY_ID { get; set; }
        public DateTime PERIOD_START { get; set; }
        public DateTime PERIOD_END { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
    }
}
