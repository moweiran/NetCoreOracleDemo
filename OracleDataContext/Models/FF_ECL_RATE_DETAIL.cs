using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_ECL_RATE_DETAIL
    {
        public decimal FF_ECL_RATE_DETAIL_ID { get; set; }
        public decimal? FF_ECL_RATE_ID { get; set; }
        public decimal FF_ECL_PRODUCT_LEVEL_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal? RATE_COST { get; set; }
        public decimal? ADD_PEER { get; set; }
        public decimal? RATE_PEER { get; set; }
        public decimal? ADD_SALES { get; set; }
        public decimal? RATE_SALES { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? ADD_PUBLIC { get; set; }
        public decimal? RATE_PUBLIC { get; set; }
        public decimal? RATE_COST_CONTINUED { get; set; }
        public decimal? ADD_PEER_CONTINUED { get; set; }
        public decimal? RATE_PEER_CONTINUED { get; set; }
        public decimal? ADD_SALES_CONTINUED { get; set; }
        public decimal? RATE_SALES_CONTINUED { get; set; }
        public decimal? ADD_PUBLIC_CONTINUED { get; set; }
        public decimal? RATE_PUBLIC_CONTINUED { get; set; }

        public virtual FF_ECL_RATE FF_ECL_RATE_ { get; set; }
    }
}
