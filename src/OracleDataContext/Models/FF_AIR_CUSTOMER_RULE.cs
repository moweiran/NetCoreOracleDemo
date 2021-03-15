using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_AIR_CUSTOMER_RULE
    {
        public decimal FF_AIR_CUSTOMER_RULE_ID { get; set; }
        public decimal FF_AIR_PRODUCT_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal? CUSTOMER_MIN_ADD { get; set; }
        public decimal? CUSTOMER_NORMAL_ADD { get; set; }
        public decimal? CUSTOMER_45_ADD { get; set; }
        public decimal? CUSTOMER_100_ADD { get; set; }
        public decimal? CUSTOMER_300_ADD { get; set; }
        public decimal? CUSTOMER_500_ADD { get; set; }
        public decimal? CUSTOMER_1000_ADD { get; set; }
        public bool? IS_AUTOMATIC { get; set; }
        public bool? IS_AUTOPRICE { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
    }
}
