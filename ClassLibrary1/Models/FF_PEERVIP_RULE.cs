using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_PEERVIP_RULE
    {
        public decimal FF_PEERVIP_RULE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal PRODUCT_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal CUSTOMER_COMPANY_ID { get; set; }
        public decimal? GP20_ADD { get; set; }
        public decimal? GP40_ADD { get; set; }
        public decimal? HQ40_ADD { get; set; }
        public decimal? GP45_ADD { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_USER_NAME { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
    }
}
