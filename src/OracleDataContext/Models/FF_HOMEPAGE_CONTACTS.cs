using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_HOMEPAGE_CONTACTS
    {
        public decimal FF_HOMEPAGE_CONTACT_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal COMPANY_ID { get; set; }
        public string CONTACT_NAME { get; set; }
        public string CONTACT_TEL { get; set; }
        public string CONTACT_EMAIL { get; set; }
        public string ADDRESS { get; set; }
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
        public decimal? CITY_ID { get; set; }
        public decimal? UI_INDEX { get; set; }
        public decimal? FILE_ID { get; set; }
    }
}
