using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_RTLCL_PRODUCT
    {
        public FF_RTLCL_PRODUCT()
        {
            FF_RTLCL_PRODUCT_LEVEL = new HashSet<FF_RTLCL_PRODUCT_LEVEL>();
        }

        public decimal FF_RTLCL_PRODUCT_ID { get; set; }
        public decimal FF_RTLCL_PRODUCT_LIST_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal START_CITY_ID { get; set; }
        public decimal DEST_CITY_ID { get; set; }
        public string VIA_NAME { get; set; }
        public string CARGO_TYPE { get; set; }
        public decimal? CBM_KGS { get; set; }
        public string SCHEDULE { get; set; }
        public string TT { get; set; }
        public string REMARK { get; set; }
        public decimal LEVEL_TYPE { get; set; }
        public decimal? TOTAL_ORDER { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }

        public virtual FF_RTLCL_PRODUCT_LIST FF_RTLCL_PRODUCT_LIST { get; set; }
        public virtual ICollection<FF_RTLCL_PRODUCT_LEVEL> FF_RTLCL_PRODUCT_LEVEL { get; set; }
    }
}
