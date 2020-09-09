using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class MV_SEARCH_FCL_PUBLIC_RATE
    {
        public decimal FF_RATE_ID { get; set; }
        public decimal RATE_SOURCE { get; set; }
        public decimal CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public decimal? CLOSE_TIME { get; set; }
        public decimal? LEAVE_TIME { get; set; }
        public decimal TT { get; set; }
        public decimal RECEIPT_ID { get; set; }
        public string RECEIPT_CODE { get; set; }
        public decimal? RECEIPT_CITY_ID { get; set; }
        public decimal POL_ID { get; set; }
        public string POL_CODE { get; set; }
        public decimal? POL_CITY_ID { get; set; }
        public decimal? VIA_ID { get; set; }
        public string VIA_CODE { get; set; }
        public decimal? VIA_CITY_ID { get; set; }
        public decimal POD_ID { get; set; }
        public string POD_CODE { get; set; }
        public decimal? POD_CITY_ID { get; set; }
        public decimal DELIVERY_ID { get; set; }
        public string DELIVERY_CODE { get; set; }
        public decimal? DELIVERY_CITY_ID { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public decimal? GP20 { get; set; }
        public decimal? GP40 { get; set; }
        public decimal? HQ40 { get; set; }
        public decimal? GP45 { get; set; }
    }
}
