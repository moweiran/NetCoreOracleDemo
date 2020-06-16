using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_ECL_PRODUCT_VIPRULE
    {
        public decimal FF_ECL_PRODUCT_VIPRULE_ID { get; set; }
        public decimal FF_ECL_PRODUCT_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal CUSTOMER_COMPANY_ID { get; set; }
        public decimal FF_ECL_PRODUCT_LEVEL_ID { get; set; }
        public decimal RULE_ADD { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? RATE_ADD_CONTINUED { get; set; }
    }
}
