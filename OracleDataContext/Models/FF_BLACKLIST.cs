using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_BLACKLIST
    {
        public decimal FF_BLACKLIST_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string FF_SHORTNAME { get; set; }
        public decimal? CUSTOMER_TYPE { get; set; }
        public decimal? CUSTOMER_SOURCE { get; set; }
        public decimal COMPANY_ID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public string REMARK { get; set; }
    }
}
