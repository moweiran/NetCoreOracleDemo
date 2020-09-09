using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_USERINFO_BAK
    {
        public decimal USER_ID { get; set; }
        public decimal COMPANY_ID { get; set; }
        public string COMPANY_NAME_EN { get; set; }
        public string COMPANY_NAME_CN { get; set; }
        public string COMPANY_NAME_TW { get; set; }
        public string COMPANY_SHORTNAME_EN { get; set; }
        public string COMPANY_SHORTNAME_CN { get; set; }
        public string COMPANY_SHORTNAME_TW { get; set; }
        public decimal? PERSON_ID { get; set; }
        public string USERCODE { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string FULLNAME { get; set; }
        public string GENDER { get; set; }
        public string TITLE { get; set; }
        public string OFFICE_PHONE { get; set; }
        public string MOBILE_PHONE { get; set; }
        public string EMAIL { get; set; }
        public string THEME { get; set; }
        public string QUESTION { get; set; }
        public string ANSWER { get; set; }
        public bool? IS_LOCAL { get; set; }
        public string SOURCE_URL { get; set; }
        public string SOURCE_NAME { get; set; }
        public string LANGUAGE { get; set; }
        public string THEMES { get; set; }
        public string NAVIGATE { get; set; }
        public decimal? PAGE_SIZE { get; set; }
        public decimal? USER_TYPE { get; set; }
        public string REMARK { get; set; }
        public bool? CONFIRM_MOBILE { get; set; }
        public bool? CONFIRM_EMAIL { get; set; }
        public string DIGITAL_CERTIFICATE_KEY { get; set; }
        public string DIGITAL_CERTIFICATE_REMARK { get; set; }
        public bool? IS_ADMIN { get; set; }
        public decimal? PERSONAL_AUTHENTICATION { get; set; }
        public DateTime? LOCK_DAY { get; set; }
        public decimal DELETE_MARK { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime? MODIFY_DATE { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
    }
}
