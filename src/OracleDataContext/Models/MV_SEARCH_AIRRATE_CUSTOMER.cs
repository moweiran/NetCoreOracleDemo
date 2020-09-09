using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class MV_SEARCH_AIRRATE_CUSTOMER
    {
        public decimal FF_AIR_INQUIRY_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public string INQUIRY_NO { get; set; }
        public decimal RECEIPT_ID { get; set; }
        public decimal RECEIPT_CITY_ID { get; set; }
        public decimal DELIVERY_ID { get; set; }
        public decimal DELIVERY_CITY_ID { get; set; }
        public DateTime? PLAN_DATE { get; set; }
        public decimal? FF_AIR_PRODUCT_ID { get; set; }
        public decimal? FF_AIR_RATE_ID { get; set; }
        public decimal? RATE_RECEIPT_ID { get; set; }
        public decimal? RATE_RECEIPT_CITY_ID { get; set; }
        public decimal? RATE_DELIVERY_ID { get; set; }
        public decimal? RATE_DELIVERY_CITY_ID { get; set; }
        public decimal? RATE_VIA_ID { get; set; }
        public decimal? PRE_PRODUCT_ID { get; set; }
        public decimal? AFTER_PRODUCT_ID { get; set; }
        public decimal? MAIN_PRODUCT_ID { get; set; }
        public decimal? PRODUCT_TYPE { get; set; }
        public DateTime? EFFECTIVE_DATE { get; set; }
        public DateTime? EXPIRATION_DATE { get; set; }
        public DateTime? RATE_UPDATEDATE { get; set; }
        public decimal? AIRLINE_ID { get; set; }
        public string CARGO_TYPE { get; set; }
        public string CURRENCY { get; set; }
        public decimal? RATE_MIN { get; set; }
        public decimal? RATE_NORMAL { get; set; }
        public decimal? RATE_45 { get; set; }
        public decimal? RATE_100 { get; set; }
        public decimal? RATE_300 { get; set; }
        public decimal? RATE_500 { get; set; }
        public decimal? RATE_1000 { get; set; }
    }
}
