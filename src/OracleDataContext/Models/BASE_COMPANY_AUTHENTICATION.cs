using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BASE_COMPANY_AUTHENTICATION
    {
        public decimal COMPANY_AUTHENTICATION_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string COMPANY_NAME_EN { get; set; }
        public string COMPANY_NAME_CN { get; set; }
        public string COMPANY_SHORTNAME_EN { get; set; }
        public string COMPANY_SHORTNAME_CN { get; set; }
        public decimal? LOGO_FILE_ID { get; set; }
        public string REGISTERED_NO { get; set; }
        public decimal? REGISTERED_FILE_ID { get; set; }
        public string ORGANIZING_CODE { get; set; }
        public decimal? ORGANIZING_FILE_ID { get; set; }
        public string CONTACTS { get; set; }
        public string CONTACT_PHONE { get; set; }
        public string EMAIL { get; set; }
        public string FAX { get; set; }
        public string ADDRESS { get; set; }
        public decimal? COUNTRY_ID { get; set; }
        public decimal? PROVINCE_ID { get; set; }
        public decimal? CITY_ID { get; set; }
        public decimal? STATUS { get; set; }
        public decimal? DELETE_MARK { get; set; }
        public decimal? CHECK_RESULT { get; set; }
        public DateTime? CHECK_DATE { get; set; }
        public decimal? CHECK_USERID { get; set; }
        public string CHECK_FULLNAME { get; set; }
        public string CHECK_OPINION { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public string COMPANY_WEBSITE { get; set; }
        public string COMPANY_CODE { get; set; }
        public string COMPANY_CLASS { get; set; }
    }
}
