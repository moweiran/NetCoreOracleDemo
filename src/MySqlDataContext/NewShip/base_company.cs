using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class base_company
    {
        public long COMPANY_ID { get; set; }
        public string COMPANY_CODE { get; set; }
        public string COMPANY_NAME_EN { get; set; }
        public string COMPANY_NAME_CN { get; set; }
        public string COMPANY_SHORTNAME_EN { get; set; }
        public string COMPANY_SHORTNAME_CN { get; set; }
        public string COMPANY_CLASS { get; set; }
        public string LOGO { get; set; }
        public long? LOGO_FILE_ID { get; set; }
        public string LARGEICON { get; set; }
        public long? LARGEICON_FILE_ID { get; set; }
        public string REGISTERED_NO { get; set; }
        public string REGISTERED_FILE { get; set; }
        public long? REGISTERED_FILE_ID { get; set; }
        public string ORGANIZING_CODE { get; set; }
        public string ORGANIZING_FILE { get; set; }
        public long? ORGANIZING_FILE_ID { get; set; }
        public string CONTACTS { get; set; }
        public string CONTACT_PHONE { get; set; }
        public string EMAIL { get; set; }
        public string FAX { get; set; }
        public string POSTCODE { get; set; }
        public string ADDRESS { get; set; }
        public long? COUNTRY_ID { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string COUNTRY_NAME_CN { get; set; }
        public string COUNTRY_NAME_EN { get; set; }
        public long? PROVINCE_ID { get; set; }
        public string PROVINCE_NAME_CN { get; set; }
        public string PROVINCE_NAME_EN { get; set; }
        public long? CITY_ID { get; set; }
        public string CITY_NAME_CN { get; set; }
        public string CITY_NAME_EN { get; set; }
        public int? CURRENT_INTEGRAL { get; set; }
        public int? STATUS { get; set; }
        public bool? IS_CERTIFICATION { get; set; }
        public bool? IS_SCHEDULE_AUTHORITY { get; set; }
        public int? COMPANY_LEVEL { get; set; }
        public int? CAMPAIGN_USER_ID { get; set; }
        public int? CAMPAIGN_USER_PLATFORM { get; set; }
        public decimal? TOTAL_REFEREE { get; set; }
        public bool? IS_SUPER_PARTNER { get; set; }
        public string SUPERPARTNER_CREATE_FULLNAME { get; set; }
        public int? PUSH_RATE_QTY { get; set; }
        public string BANK_NAME { get; set; }
        public string BANK_ACCOUNTNO { get; set; }
        public string REMARK { get; set; }
        public long? PARENT_ID { get; set; }
        public long? REFEREE_COMPANY_ID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public long CARRIER_ID { get; set; }
    }
}
