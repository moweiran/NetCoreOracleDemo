using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class MV_SEARCH_AIR_PUBLIC_RATE
    {
        public decimal FF_AIR_RATE_ID { get; set; }
        public decimal FF_AIR_PRODUCT_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal RECEIPT_ID { get; set; }
        public decimal AIRLINE_ID { get; set; }
        public decimal RECEIPT_CITY_ID { get; set; }
        public decimal DELIVERY_ID { get; set; }
        public decimal DELIVERY_CITY_ID { get; set; }
        public decimal? VIA_ID { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public decimal? PRE_RATE_ID { get; set; }
        public decimal? AFTER_RATE_ID { get; set; }
        public decimal MAIN_RATE_ID { get; set; }
        public decimal RATE_SOURCE { get; set; }
        public DateTime RATE_UPDATEDATE { get; set; }
    }
}
