using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class BASE_COMPANY
    {
        public decimal COMPANY_ID { get; set; }
        public string COMPANY_CODE { get; set; }
        public string COMPANY_NAME_EN { get; set; }
        public string COMPANY_NAME_CN { get; set; }
        public string COMPANY_SHORTNAME_EN { get; set; }
        public string COMPANY_SHORTNAME_CN { get; set; }
        public string COMPANY_CLASS { get; set; }
        public string LOGO { get; set; }
        public string LARGEICON { get; set; }
        public string REGISTERED_NO { get; set; }
        public string REGISTERED_FILE { get; set; }
        public string ORGANIZING_CODE { get; set; }
        public string ORGANIZING_FILE { get; set; }
        public string CONTACTS { get; set; }
        public string CONTACT_PHONE { get; set; }
        public string EMAIL { get; set; }
        public string FAX { get; set; }
        public string POSTCODE { get; set; }
        public string ADDRESS { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string COUNTRY_NAME_CN { get; set; }
        public string COUNTRY_NAME_EN { get; set; }
        public string PROVINCE_NAME_CN { get; set; }
        public string PROVINCE_NAME_EN { get; set; }
        public string CITY_NAME_CN { get; set; }
        public string CITY_NAME_EN { get; set; }
        public decimal? CURRENT_INTEGRAL { get; set; }
        public decimal? STATUS { get; set; }
        public string REMARK { get; set; }
        public decimal? PARENT_ID { get; set; }
        public decimal? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? FF_ID { get; set; }
        public decimal? LOGO_FILE_ID { get; set; }
        public decimal? LARGEICON_FILE_ID { get; set; }
        public decimal? REGISTERED_FILE_ID { get; set; }
        public decimal? ORGANIZING_FILE_ID { get; set; }
        public decimal? COUNTRY_ID { get; set; }
        public decimal? PROVINCE_ID { get; set; }
        public decimal? CITY_ID { get; set; }
        public bool? IS_CERTIFICATION { get; set; }
        public string COMPANY_WEBSITE { get; set; }
        public bool? IS_SCHEDULE_AUTHORITY { get; set; }
        public decimal COMPANY_LEVEL { get; set; }
        public decimal? CAMPAIGN_USER_ID { get; set; }
        public decimal? CAMPAIGN_USER_PLATFORM { get; set; }
        public string BANK_NAME { get; set; }
        public string BANK_ACCOUNTNO { get; set; }
        public bool? IS_SUPER_PARTNER { get; set; }
        public DateTime? SUPERPARTNER_CREATE_DATETIME { get; set; }
        public string SUPERPARTNER_CREATE_FULLNAME { get; set; }
        public string CONTACT_JOB { get; set; }
        public decimal? CONTACT_CARD_ID { get; set; }
        public bool? IS_SEAFCL_BANKER { get; set; }
        public bool? IS_SEALCL_BANKER { get; set; }
        public bool? IS_AIR_BANKER { get; set; }
        public bool? IS_FBA_BANKER { get; set; }
        public bool? IS_RAILWAYFCL_BANKER { get; set; }
        public bool? IS_RAILWAYLCL_BANKER { get; set; }
        public DateTime? LATEST_LOGINTIME { get; set; }
    }
}
