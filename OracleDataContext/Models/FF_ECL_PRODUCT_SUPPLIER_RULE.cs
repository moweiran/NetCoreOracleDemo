using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_ECL_PRODUCT_SUPPLIER_RULE
    {
        public decimal FF_ECLPRODUCT_SUPPLIER_RULE_ID { get; set; }
        public decimal? FF_ECL_PRODUCT_SUPPLIER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_ECL_PRODUCT_LEVEL_ID { get; set; }
        public decimal? RULE_ADD { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? RATE_ADD_CONTINUED { get; set; }

        public virtual FF_ECL_PRODUCT_SUPPLIER FF_ECL_PRODUCT_SUPPLIER_ { get; set; }
    }
}
