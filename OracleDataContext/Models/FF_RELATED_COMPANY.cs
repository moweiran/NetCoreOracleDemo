using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_RELATED_COMPANY
    {
        public decimal FF_RELATED_COMPANY_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal COMPANY_PLATFORM { get; set; }
        public decimal? RELATED_COMPANY_ID { get; set; }
        public decimal COMPANY_TYPE { get; set; }
        public string COMPANY_CODE { get; set; }
        public string COMPANY_SHORTNAME_CN { get; set; }
        public string COMPANY_SHORTNAME_EN { get; set; }
        public string COMPANY_NAME_CN { get; set; }
        public string COMPANY_NAME_EN { get; set; }
        public string CONTACTS { get; set; }
        public string CONTACT_PHONE { get; set; }
        public string EMAIL { get; set; }
        public string FAX { get; set; }
        public string POSTCODE { get; set; }
        public string ADDRESS { get; set; }
        public decimal? COUNTRY_ID { get; set; }
        public decimal? PROVINCE_ID { get; set; }
        public decimal? CITY_ID { get; set; }
        public string REMARK { get; set; }
        public decimal VALID { get; set; }
        public decimal? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
