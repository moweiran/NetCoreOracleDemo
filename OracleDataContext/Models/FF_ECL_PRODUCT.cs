using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_ECL_PRODUCT
    {
        public FF_ECL_PRODUCT()
        {
            FF_ECL_PRODUCT_FBA = new HashSet<FF_ECL_PRODUCT_FBA>();
        }

        public decimal FF_ECL_PRODUCT_ID { get; set; }
        public decimal FF_ECL_PRODUCT_LIST_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal START_CITY_ID { get; set; }
        public decimal DEST_COUNTRY_ID { get; set; }
        public string DEST_AREA { get; set; }
        public decimal CBM_KGS { get; set; }
        public string CARGO_TYPE { get; set; }
        public string TT { get; set; }
        public string REMARK { get; set; }
        public decimal? TOTAL_ORDER { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal? SHOW_INDEX { get; set; }
        public decimal FF_ECL_ZONE_ID { get; set; }
        public bool? IS_TAX { get; set; }
        public decimal PAK_TYPE { get; set; }
        public string SERVICE_PROMISE { get; set; }

        public virtual FF_ECL_PRODUCT_LIST FF_ECL_PRODUCT_LIST_ { get; set; }
        public virtual ICollection<FF_ECL_PRODUCT_FBA> FF_ECL_PRODUCT_FBA { get; set; }
    }
}
