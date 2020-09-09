using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_COMPANY
    {
        public BASE_COMPANY()
        {
            BASE_COMPANY_RIGHT = new HashSet<BASE_COMPANY_RIGHT>();
            BASE_COMPANY_ROLE = new HashSet<BASE_COMPANY_ROLE>();
        }

        public decimal COMPANY_ID { get; set; }
        public string COMPANY_CODE { get; set; }
        public string COMPANY_NAME_EN { get; set; }
        public string COMPANY_NAME_CN { get; set; }
        public string COMPANY_NAME_TW { get; set; }
        public string COMPANY_SHORTNAME_EN { get; set; }
        public string COMPANY_SHORTNAME_CN { get; set; }
        public string COMPANY_SHORTNAME_TW { get; set; }
        public string COMPANY_TYPE { get; set; }
        public decimal COMPANY_CLASS { get; set; }
        public string LOGO { get; set; }
        public string LARGEICON { get; set; }
        public string CERTIFICATE { get; set; }
        public string REGISTERED_NO { get; set; }
        public string ORGANIZING_CODE { get; set; }
        public string PHONE { get; set; }
        public string CONTACTS { get; set; }
        public string CONTACT_PHONE { get; set; }
        public string COUNTRY { get; set; }
        public string PROVINCE { get; set; }
        public string CITY { get; set; }
        public string FAX { get; set; }
        public string POSTCODE { get; set; }
        public string ADDRESS { get; set; }
        public decimal? DIGITAL_CERTIFICATE { get; set; }
        public string DIGITAL_CERTIFICATE_KEY { get; set; }
        public string DIGITAL_CERTIFICATE_REMARK { get; set; }
        public string REMARK { get; set; }
        public string REGISTERED_CAPITAL { get; set; }
        public string EMPLOYEES { get; set; }
        public decimal? LICENSES { get; set; }
        public decimal? USERS { get; set; }
        public decimal? PARENT_ID { get; set; }
        public decimal? SEQUENCE { get; set; }
        public string SEQUENCE_STRING { get; set; }
        public decimal? DELETE_MARK { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime? MODIFY_DATE { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
        public decimal STATUS { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string COUNTRY_EN { get; set; }
        public string PROVINCE_EN { get; set; }
        public string CITY_EN { get; set; }
        public string SCAS_CODE { get; set; }
        public bool? IS_PUBLIC_CARRIER { get; set; }
        public bool? IS_ONLY_FEEDER_CUSTOMER { get; set; }
        public decimal COUNTRY_ID { get; set; }
        public decimal? PROVINCE_ID { get; set; }
        public decimal? CITY_ID { get; set; }
        public string YDW_CODE { get; set; }
        public string CARGOTRACK_WEBSITE { get; set; }

        public virtual ICollection<BASE_COMPANY_RIGHT> BASE_COMPANY_RIGHT { get; set; }
        public virtual ICollection<BASE_COMPANY_ROLE> BASE_COMPANY_ROLE { get; set; }
    }
}
