using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_ECL_PRODUCT_FBA
    {
        public decimal FF_ECL_PRODUCT_FBA_ID { get; set; }
        public decimal FF_ECL_PRODUCT_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FBA_ID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }

        public virtual FF_ECL_PRODUCT FF_ECL_PRODUCT_ { get; set; }
    }
}
