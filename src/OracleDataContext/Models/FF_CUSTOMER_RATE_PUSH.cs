using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_CUSTOMER_RATE_PUSH
    {
        public decimal CUSTOMER_RATE_PUSH_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal MAIL_INFO_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public string TO_MAIL { get; set; }
        public decimal MONTHS { get; set; }
        public decimal? AMOUNT { get; set; }
        public DateTime? EFFECTIVE_DATE { get; set; }
        public DateTime? EXPIRATION_DATE { get; set; }
        public string MAIL_SUBJECT { get; set; }
        public string MAIL_SIGN { get; set; }
        public decimal STATUS { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_USER_NAME { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
    }
}
