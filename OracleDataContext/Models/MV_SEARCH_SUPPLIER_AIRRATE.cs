using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class MV_SEARCH_SUPPLIER_AIRRATE
    {
        public decimal FF_AIR_RATE_ID { get; set; }
        public decimal FF_AIR_PRODUCT_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal AIRLINE_ID { get; set; }
        public decimal RATE_SOURCE { get; set; }
        public decimal SUPPLIER_ID { get; set; }
        public decimal TOP_SUPPLIER_ID { get; set; }
        public decimal? PRE_PRODUCT_ID { get; set; }
        public decimal MAIN_PRODUCT_ID { get; set; }
        public decimal? AFTER_PRODUCT_ID { get; set; }
        public decimal? PRE_RATE_ID { get; set; }
        public decimal MAIN_RATE_ID { get; set; }
        public decimal? AFTER_RATE_ID { get; set; }
        public decimal PRODUCT_TYPE { get; set; }
        public decimal RECEIPT_ID { get; set; }
        public decimal RECEIPT_CITY_ID { get; set; }
        public decimal POL_ID { get; set; }
        public decimal POL_CITY_ID { get; set; }
        public decimal POD_ID { get; set; }
        public decimal POD_CITY_ID { get; set; }
        public decimal DELIVERY_ID { get; set; }
        public decimal DELIVERY_CITY_ID { get; set; }
        public decimal? VIA_ID { get; set; }
        public string REMARK { get; set; }
        public decimal STATUS { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public DateTime RATE_UPDATEDATE { get; set; }
        public bool DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public string CARGO_TYPE { get; set; }
        public decimal? TOTAL_ORDER { get; set; }
        public string COMPANY_NAME_CN { get; set; }
        public string COMPANY_NAME_EN { get; set; }
        public string COMPANY_CODE { get; set; }
        public string COMPANY_WEBSITE { get; set; }
        public bool? IS_CERTIFICATION { get; set; }
        public bool? IS_SUPER_PARTNER { get; set; }
        public decimal? PUBLIC_M { get; set; }
        public decimal? PUBLIC_N { get; set; }
        public decimal? PUBLIC_45 { get; set; }
        public decimal? PUBLIC_100 { get; set; }
        public decimal? PUBLIC_300 { get; set; }
        public decimal? PUBLIC_500 { get; set; }
        public decimal? PUBLIC_1000 { get; set; }
    }
}
