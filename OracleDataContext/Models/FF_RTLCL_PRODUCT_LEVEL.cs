using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_RTLCL_PRODUCT_LEVEL
    {
        public decimal FF_RTLCL_PRODUCT_LEVEL_ID { get; set; }
        public decimal? FF_RTLCL_PRODUCT_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal BEGIN_CBM { get; set; }
        public decimal? END_CBM { get; set; }
        public bool? IS_MAX { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }

        public virtual FF_RTLCL_PRODUCT FF_RTLCL_PRODUCT_ { get; set; }
    }
}
