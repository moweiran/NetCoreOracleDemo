using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class MV_SEARCH_FBA_PUBLIC_RATE
    {
        public decimal FF_ECL_RATE_ID { get; set; }
        public decimal FF_ECL_RATE_LIST_ID { get; set; }
        public decimal FF_ECL_PRODUCT_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal RATE_SOURCE { get; set; }
        public decimal SUPPLIER_ID { get; set; }
        public decimal TOP_SUPPLIER_ID { get; set; }
        public decimal START_CITY_ID { get; set; }
        public decimal? MIN_SALE { get; set; }
        public decimal? BAF { get; set; }
        public decimal? DISCOUNT { get; set; }
        public string CURRENCY { get; set; }
        public DateTime? EFFECTIVE_DATE { get; set; }
        public DateTime? EXPIRATION_DATE { get; set; }
        public decimal STATUS { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public string RATE_REMARK { get; set; }
        public decimal CBM_KGS { get; set; }
        public string CARGO_TYPE { get; set; }
        public string TT { get; set; }
        public decimal? TOTAL_ORDER { get; set; }
        public string PRODUCT_REMARK { get; set; }
        public decimal FF_ECL_ZONE_ID { get; set; }
        public bool IS_TAX { get; set; }
        public decimal PAK_TYPE { get; set; }
        public string SERVICE_PROMISE { get; set; }
        public decimal LEVEL_TYPE { get; set; }
        public string PRODUCT_NAME { get; set; }
        public decimal ECL_TYPE { get; set; }
        public decimal CHARGE_UNIT { get; set; }
        public string CHANNEL { get; set; }
        public decimal FF_ECL_PRODUCT_LIST_ID { get; set; }
        public decimal RATE_IMPORT_TYPE { get; set; }
        public bool IS_FBA { get; set; }
        public bool IS_SPECIALLINE { get; set; }
        public bool IS_EXPRESS { get; set; }
        public bool IS_PAK { get; set; }
        public string WAREHOUSE_ADDRESS { get; set; }
        public string WAREHOUSE_TEL { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal? OTHER_FEE { get; set; }
        public string ZONE_NAME { get; set; }
        public decimal FBA_ID { get; set; }
        public decimal DEST_COUNTRY_ID { get; set; }
    }
}
