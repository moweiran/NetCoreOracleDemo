using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_LCLMAIN_PRODUCT_RULE
    {
        public decimal FF_LCLMAIN_PRODUCT_RULE_ID { get; set; }
        public decimal FF_LCLMAIN_PRODUCT_LIST_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal? STANDARD_SALES { get; set; }
        public decimal? STANDARD_PEER { get; set; }
        public decimal? ALLIN_SALES { get; set; }
        public decimal? ALLIN_PEER { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
