using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_RTFCL_RATE_CUSTOMER
    {
        public decimal FF_RTFCL_RATE_CUSTOMER_ID { get; set; }
        public decimal FF_RTFCL_RATE_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal? GP20_COST { get; set; }
        public decimal? GP40_COST { get; set; }
        public decimal? HQ40_COST { get; set; }
        public decimal? GP20 { get; set; }
        public decimal? GP40 { get; set; }
        public decimal? HQ40 { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
