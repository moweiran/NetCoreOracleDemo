using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class MV_SEARCH_SUPPLIER_RTLCLRATE
    {
        public decimal FF_RTLCL_RATE_ID { get; set; }
        public decimal FF_RTLCL_PRODUCT_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal TOP_SUPPLIER_ID { get; set; }
        public decimal START_CITY_ID { get; set; }
        public decimal DEST_CITY_ID { get; set; }
        public string CURRENCY { get; set; }
        public decimal? MIN_SALE { get; set; }
        public DateTime? EFFECTIVE_DATE { get; set; }
        public DateTime? EXPIRATION_DATE { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public string VIA_NAME { get; set; }
        public decimal? CBM_KGS { get; set; }
        public decimal LEVEL_TYPE { get; set; }
        public string CARGO_TYPE { get; set; }
        public string SCHEDULE { get; set; }
        public string TT { get; set; }
        public decimal? TOTAL_ORDER { get; set; }
        public string COMPANY_CODE { get; set; }
        public string COMPANY_WEBSITE { get; set; }
        public string COMPANY_NAME_CN { get; set; }
        public string COMPANY_NAME_EN { get; set; }
        public bool? IS_SUPER_PARTNER { get; set; }
        public bool? IS_CERTIFICATION { get; set; }
        public decimal? PUBLIC_ADD { get; set; }
    }
}
