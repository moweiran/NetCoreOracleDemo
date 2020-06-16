using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_CRM
    {
        public decimal FF_CRM_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string FF_SHORTNAME { get; set; }
        public string FF_NAME_CN { get; set; }
        public string FF_NAME_EN { get; set; }
        public decimal CUSTOMER_TYPE { get; set; }
        public decimal CUSTOMER_SOURCE { get; set; }
        public decimal CUSTOMER_PROPERTY { get; set; }
        public decimal? SALES_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public string CUSTOMER_SHORTNAME { get; set; }
        public string CUSTOMER_NAME_CN { get; set; }
        public string CUSTOMER_NAME_EN { get; set; }
        public decimal? STATUS { get; set; }
        public bool? IS_CONFIRM { get; set; }
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
        public decimal FF_COMPANY_ID { get; set; }
        public decimal CUSTOMER_COMPANY_ID { get; set; }
    }
}
