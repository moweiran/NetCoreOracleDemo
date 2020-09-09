using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_AIRMAIN_PREEVIP_RULE
    {
        public decimal FF_AIRMAIN_PREEVIP_RULE_ID { get; set; }
        public decimal FF_AIRMAIN_PRODUCT_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal CUSTOMER_COMPANY_ID { get; set; }
        public decimal? PEERVIP_MIN_ADD { get; set; }
        public decimal? PEERVIP_NORMAL_ADD { get; set; }
        public decimal? PEERVIP_45_ADD { get; set; }
        public decimal? PEERVIP_100_ADD { get; set; }
        public decimal? PEERVIP_300_ADD { get; set; }
        public decimal? PEERVIP_500_ADD { get; set; }
        public decimal? PEERVIP_1000_ADD { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
