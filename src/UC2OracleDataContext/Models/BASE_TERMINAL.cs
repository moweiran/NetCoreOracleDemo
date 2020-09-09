using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_TERMINAL
    {
        public decimal BASE_TERMINAL_ID { get; set; }
        public decimal? BASE_COUNTRY_ID { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string COUNTRY_NAME_EN { get; set; }
        public string COUNTRY_NAME_CN { get; set; }
        public decimal? BASE_PROVINCE_ID { get; set; }
        public string PROVINCE_CODE { get; set; }
        public string PROVINCE_NAME_EN { get; set; }
        public string PROVINCE_NAME_CN { get; set; }
        public decimal BASE_CITY_ID { get; set; }
        public string CITY_NAME_EN { get; set; }
        public string CITY_NAME_CN { get; set; }
        public decimal BASE_LOCATION_ID { get; set; }
        public string LOCATION_CODE { get; set; }
        public string LOCATION_NAME_EN { get; set; }
        public string LOCATION_NAME_CN { get; set; }
        public string TERMINAL_NAME_EN { get; set; }
        public string TERMINAL_NAME_CN { get; set; }
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

        public virtual BASE_LOCATION BASE_LOCATION_ { get; set; }
    }
}
