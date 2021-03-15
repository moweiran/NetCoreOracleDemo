using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_AIRMAIN_PRODUCT_RULE
    {
        public decimal FF_AIRMAIN_PRODUCT_RULE_ID { get; set; }
        public decimal FF_AIRMAIN_PRODUCT_LIST_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal? SALES_MIN_ADD { get; set; }
        public decimal? SALES_NORMAL_ADD { get; set; }
        public decimal? SALES_45_ADD { get; set; }
        public decimal? SALES_100_ADD { get; set; }
        public decimal? SALES_300_ADD { get; set; }
        public decimal? SALES_500_ADD { get; set; }
        public decimal? SALES_1000_ADD { get; set; }
        public decimal? PEER_MIN_ADD { get; set; }
        public decimal? PEER_NORMAL_ADD { get; set; }
        public decimal? PEER_45_ADD { get; set; }
        public decimal? PEER_100_ADD { get; set; }
        public decimal? PEER_300_ADD { get; set; }
        public decimal? PEER_500_ADD { get; set; }
        public decimal? PEER_1000_ADD { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
