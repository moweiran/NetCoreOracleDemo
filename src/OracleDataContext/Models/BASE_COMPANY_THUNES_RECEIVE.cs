using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class BASE_COMPANY_THUNES_RECEIVE
    {
        public decimal ID { get; set; }
        public decimal FF_ID { get; set; }
        public string COMPANY_NAME { get; set; }
        public string REGISTRATION_NUMBER { get; set; }
        public decimal COUNTRY_REGISTRATION { get; set; }
        public string ADDRESS { get; set; }
        public string CITY { get; set; }
        public string POSTAL_CODE { get; set; }
        public string BANK_ACCOUNT_NUMBER { get; set; }
        public string CONTACT_NUMBER { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? BANKID { get; set; }
    }
}
