using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_LCLMAIN_PRODUCTS
    {
        public FF_LCLMAIN_PRODUCTS()
        {
            FF_LCLMAIN_PRODUCT_LEVEL = new HashSet<FF_LCLMAIN_PRODUCT_LEVEL>();
        }

        public decimal FF_LCLMAIN_PRODUCT_ID { get; set; }
        public decimal FF_LCLMAIN_PRODUCT_LIST_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal POL_ID { get; set; }
        public decimal POL_CITY_ID { get; set; }
        public decimal POD_ID { get; set; }
        public decimal POD_CITY_ID { get; set; }
        public decimal CBM_STANDARD { get; set; }
        public decimal CBM_ALLIN { get; set; }
        public bool? IS_CC { get; set; }
        public decimal TT { get; set; }
        public string REMARK { get; set; }
        public decimal STATUS { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public string MAIN_VIA { get; set; }
        public string POL_WAREHOUSE { get; set; }
        public string POD_WAREHOUSE { get; set; }
        public decimal LEVEL_TYPE { get; set; }
        public string CARGO_TYPE { get; set; }

        public virtual ICollection<FF_LCLMAIN_PRODUCT_LEVEL> FF_LCLMAIN_PRODUCT_LEVEL { get; set; }
    }
}
