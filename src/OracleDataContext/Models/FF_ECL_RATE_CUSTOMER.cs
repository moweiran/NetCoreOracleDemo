using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_ECL_RATE_CUSTOMER
    {
        public decimal FF_ECL_RATE_CUSTOMER_ID { get; set; }
        public decimal FF_ECL_RATE_ID { get; set; }
        public decimal FF_ECL_RATE_DETAIL_ID { get; set; }
        public decimal FF_ECL_PRODUCT_LEVEL_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal? RATE_COST { get; set; }
        public decimal? RATE_CUSTOMER { get; set; }
        public bool? IS_AUTOMATIC { get; set; }
        public bool? IS_AUTOPRICE { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? RATE_COST_CONTINUED { get; set; }
        public decimal? RATE_CUSTOMER_CONTINUED { get; set; }
    }
}
