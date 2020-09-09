using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class MV_SEARCH_RTLCL_RATE
    {
        public decimal FF_RTLCL_RATE_ID { get; set; }
        public decimal FF_RTLCL_PRODUCT_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal RATE_SOURCE { get; set; }
        public decimal SUPPLIER_ID { get; set; }
        public decimal TOP_SUPPLIER_ID { get; set; }
        public decimal START_CITY_ID { get; set; }
        public decimal DEST_CITY_ID { get; set; }
        public string CURRENCY { get; set; }
        public decimal? MIN_SALE { get; set; }
        public DateTime? EFFECTIVE_DATE { get; set; }
        public DateTime? EXPIRATION_DATE { get; set; }
        public string RATE_REMARK { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public string VIA_NAME { get; set; }
        public string CARGO_TYPE { get; set; }
        public string SCHEDULE { get; set; }
        public string TT { get; set; }
        public decimal? CBM_KGS { get; set; }
        public decimal LEVEL_TYPE { get; set; }
        public decimal? TOTAL_ORDER { get; set; }
        public string PRODUCT_REMARK { get; set; }
    }
}
