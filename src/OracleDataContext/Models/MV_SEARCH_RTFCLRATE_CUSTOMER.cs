using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class MV_SEARCH_RTFCLRATE_CUSTOMER
    {
        public decimal FF_RTFCL_INQUIRY_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public string INQUIRY_NO { get; set; }
        public decimal START_CITY_ID { get; set; }
        public decimal DEST_CITY_ID { get; set; }
        public DateTime? PLAN_DATE { get; set; }
        public decimal? FF_RTFCL_PRODUCT_ID { get; set; }
        public decimal? FF_RTFCL_RATE_ID { get; set; }
        public decimal? FF_RTFCL_RATE_LIST_ID { get; set; }
        public decimal? RATE_RTFCL_PRODUCT_ID { get; set; }
        public decimal? RATE_FF_ID { get; set; }
        public decimal? RATE_SOURCE { get; set; }
        public decimal? SUPPLIER_ID { get; set; }
        public decimal? TOP_SUPPLIER_ID { get; set; }
        public decimal? RATE_START_CITY_ID { get; set; }
        public decimal? RATE_DEST_CITY_ID { get; set; }
        public string VIA_NAME { get; set; }
        public string CURRENCY { get; set; }
        public DateTime? EFFECTIVE_DATE { get; set; }
        public DateTime? EXPIRATION_DATE { get; set; }
        public decimal? STATUS { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public DateTime? MODIFY_DATETIME { get; set; }
        public string RATE_REMARK { get; set; }
        public string CARGO_TYPE { get; set; }
        public string TT { get; set; }
        public string SCHEDULE { get; set; }
        public decimal? TOTAL_ORDER { get; set; }
        public string PRODUCT_REMARK { get; set; }
        public decimal? FF_COMPANY_ID { get; set; }
        public decimal? GP20 { get; set; }
        public decimal? GP40 { get; set; }
        public decimal? HQ40 { get; set; }
    }
}
