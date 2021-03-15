using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_CUSTOMER
    {
        public decimal CUSTOMER_ID { get; set; }
        public decimal? COMPANY_ID { get; set; }
        public decimal CUSTOMER_SOURCE { get; set; }
        public decimal SOURCE_PLATFORM { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CUSTOMER_TYPE { get; set; }
        public string CUSTOMER_CODE { get; set; }
        public string CUSTOMER_SHORTNAME_CN { get; set; }
        public string CUSTOMER_SHORTNAME_EN { get; set; }
        public string CUSTOMER_NAME_CN { get; set; }
        public string CUSTOMER_NAME_EN { get; set; }
        public bool? IS_AGENCY { get; set; }
        public decimal? SALES_ID { get; set; }
        public string REGISTERED_NO { get; set; }
        public string ORGANIZING_CODE { get; set; }
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
        public bool? IS_LCL_DEST { get; set; }
        public string CONTACT_MOBILE { get; set; }
        public string SAP_NO { get; set; }
    }
}
