using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_ECL_PRODUCT_LEVEL
    {
        public decimal FF_ECL_PRODUCT_LEVEL_ID { get; set; }
        public decimal FF_ECL_PRODUCT_LIST_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal BEGIN_LEVEL { get; set; }
        public decimal END_LEVEL { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal RATE_MODEL { get; set; }
        public decimal? FIRST_WEIGHT { get; set; }
        public decimal? CONTINUED_WEIGHT { get; set; }

        public virtual FF_ECL_PRODUCT_LIST FF_ECL_PRODUCT_LIST_ { get; set; }
    }
}
