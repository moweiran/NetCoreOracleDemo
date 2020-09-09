using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_CURRENCY
    {
        public decimal BASE_CURRENCY_ID { get; set; }
        public string CURRENCY_CODE { get; set; }
        public string CURRENCY_NAME { get; set; }
        public string CURRENCY_FULLNAME { get; set; }
        public decimal? COUNTRY_ID { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string COUNTRY_NAME { get; set; }
        public string REMARK { get; set; }
        public bool? VALID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
