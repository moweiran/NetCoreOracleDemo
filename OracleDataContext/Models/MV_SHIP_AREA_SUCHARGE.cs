using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class MV_SHIP_AREA_SUCHARGE
    {
        public decimal CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public decimal RECEIPT_AREA_ID { get; set; }
        public string RECEIPT_AREA_CNAME { get; set; }
        public string RECEIPT_AREA_ENAME { get; set; }
        public decimal COUNTRY_AREA_ID { get; set; }
        public string COUNTRY_AREA_CNAME { get; set; }
        public string COUNTRY_AREA_ENAME { get; set; }
        public string FEE_CODE { get; set; }
        public decimal UNIT { get; set; }
        public string CURRENCY { get; set; }
        public string PPCC { get; set; }
        public decimal SURCHARGE_TYPE { get; set; }
        public decimal CARGO_TYPE { get; set; }
        public decimal GP20 { get; set; }
        public decimal GP40 { get; set; }
        public decimal HQ40 { get; set; }
        public decimal GP45 { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public decimal? REC_AREA_SUR_ID { get; set; }
        public decimal? REC_AREA_SUR_DETS_ID { get; set; }
        public decimal? REC_AREA_SUR_DETS_COUAREAS_ID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
    }
}
