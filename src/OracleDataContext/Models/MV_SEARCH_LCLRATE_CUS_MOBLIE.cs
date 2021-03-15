using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class MV_SEARCH_LCLRATE_CUS_MOBLIE
    {
        public decimal FF_LCL_RATE_ID { get; set; }
        public decimal RATE_FF_ID { get; set; }
        public decimal? LCL_PRODUCT_ID { get; set; }
        public decimal RATE_RECEIPT_ID { get; set; }
        public decimal RATE_RECEIPT_CITY_ID { get; set; }
        public decimal RATE_DELIVERY_ID { get; set; }
        public decimal RATE_DELIVERY_CITY_ID { get; set; }
        public decimal RATE_POL_ID { get; set; }
        public decimal RATE_POL_CITY_ID { get; set; }
        public decimal RATE_POD_ID { get; set; }
        public decimal RATE_POD_CITY_ID { get; set; }
        public decimal? RATE_VIA_ID { get; set; }
        public decimal RATE_TT { get; set; }
        public decimal? MIN_CBM { get; set; }
        public decimal CBM_STANDARD { get; set; }
        public decimal CBM_ALLIN { get; set; }
        public bool IS_CC { get; set; }
        public decimal? PRE_RATE { get; set; }
        public decimal? AFTER_RATE { get; set; }
        public decimal? PRE_RATE_ID { get; set; }
        public decimal? AFTER_RATE_ID { get; set; }
        public decimal? PRE_PRODUCT_ID { get; set; }
        public decimal? AFTER_PRODUCT_ID { get; set; }
        public decimal MAIN_PRODUCT_ID { get; set; }
        public decimal PRODUCT_TYPE { get; set; }
        public decimal? FF_LCLMAIN_PRODUCT_LEVEL_ID { get; set; }
        public decimal TOP_SUPPLIER_ID { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public DateTime RATE_UPDATEDATE { get; set; }
        public decimal? PRE_CBMKGS { get; set; }
        public decimal? AFTER_CBMKGS { get; set; }
        public decimal? PRE_MIN { get; set; }
        public decimal? AFTER_MIN { get; set; }
        public string MAIN_VIA { get; set; }
        public decimal LEVEL_TYPE { get; set; }
        public decimal RATE_TYPE { get; set; }
        public decimal CUSTOMER_ID { get; set; }
    }
}
