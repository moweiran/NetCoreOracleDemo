using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_RTLCL_PRODUCT_SUPPLIER_RULE
    {
        public decimal RTLCL_PRODUCT_SUPPLIER_RULE_ID { get; set; }
        public decimal FF_RTLCL_PRODUCT_SUPPLIER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_RTLCL_PRODUCT_LEVEL_ID { get; set; }
        public decimal? RULE_ADD { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
    }
}
