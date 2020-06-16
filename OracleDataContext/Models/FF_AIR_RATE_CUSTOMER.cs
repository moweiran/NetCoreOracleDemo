using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_AIR_RATE_CUSTOMER
    {
        public decimal FF_AIR_RATE_CUSTOMER_ID { get; set; }
        public decimal FF_AIR_RATE_ID { get; set; }
        public decimal FF_AIR_RATE_DETAIL_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public string CURRENCY { get; set; }
        public decimal? RATE_MIN { get; set; }
        public decimal? RATE_NORMAL { get; set; }
        public decimal? RATE_45 { get; set; }
        public decimal? RATE_100 { get; set; }
        public decimal? RATE_300 { get; set; }
        public decimal? RATE_500 { get; set; }
        public decimal? RATE_1000 { get; set; }
        public decimal? COST_MIN { get; set; }
        public decimal? COST_NORMAL { get; set; }
        public decimal? COST_45 { get; set; }
        public decimal? COST_100 { get; set; }
        public decimal? COST_300 { get; set; }
        public decimal? COST_500 { get; set; }
        public decimal? COST_1000 { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
