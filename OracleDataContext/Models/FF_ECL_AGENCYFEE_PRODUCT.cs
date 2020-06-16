using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_ECL_AGENCYFEE_PRODUCT
    {
        public decimal ECL_AGENCYFEE_PRODUCT_ID { get; set; }
        public decimal? FF_ECL_AGENCYFEE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_ECL_PRODUCT_ID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }

        public virtual FF_ECL_AGENCYFEE FF_ECL_AGENCYFEE_ { get; set; }
    }
}
