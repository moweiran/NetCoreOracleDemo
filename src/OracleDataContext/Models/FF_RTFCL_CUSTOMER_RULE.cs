using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_RTFCL_CUSTOMER_RULE
    {
        public decimal FF_RTFCL_CUSTOMER_RULE_ID { get; set; }
        public decimal FF_RTFCL_PRODUCT_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public bool? IS_AUTOMATIC { get; set; }
        public bool? IS_AUTOPRICE { get; set; }
        public decimal? GP20_ADD { get; set; }
        public decimal? GP40_ADD { get; set; }
        public decimal? HQ40_ADD { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
