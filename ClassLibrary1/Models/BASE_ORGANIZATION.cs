using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class BASE_ORGANIZATION
    {
        public decimal ORGANIZATION_ID { get; set; }
        public decimal? COMPANY_ID { get; set; }
        public string ORGANIZATION_CODE { get; set; }
        public string ORGANIZATION_NAME { get; set; }
        public string CONTACTS { get; set; }
        public string PHONE { get; set; }
        public string FAX { get; set; }
        public string EMAIL { get; set; }
        public string POSTCODE { get; set; }
        public string ADDRESS { get; set; }
        public decimal? PARENT_ID { get; set; }
        public string ORGANIZATION_REMARK { get; set; }
        public decimal? USERS { get; set; }
        public decimal? SEQUENCE { get; set; }
        public string SEQUENCE_STRING { get; set; }
        public decimal? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? TOP_ORGANIZATION_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string ORGANIZATION_NAME_EN { get; set; }
    }
}
