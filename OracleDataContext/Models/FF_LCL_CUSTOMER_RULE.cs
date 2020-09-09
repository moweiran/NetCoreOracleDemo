using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_LCL_CUSTOMER_RULE
    {
        public decimal FF_LCL_CUSTOMER_RULE_ID { get; set; }
        public decimal FF_LCL_PRODUCT_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_LCLMAIN_PRODUCT_LEVEL_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal? STANDARD_ADD { get; set; }
        public decimal? ALLIN_ADD { get; set; }
        public bool? IS_AUTOMATIC { get; set; }
        public bool? IS_AUTOPRICE { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
