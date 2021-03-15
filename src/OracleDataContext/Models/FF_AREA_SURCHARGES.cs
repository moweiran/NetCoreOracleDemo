using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_AREA_SURCHARGES
    {
        public decimal FF_AREA_SURCHARGE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal DATA_SOURCE { get; set; }
        public decimal SHIP_SURCHARGE_ID { get; set; }
        public decimal SURCHARGE_TYPE { get; set; }
        public decimal CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public decimal RECEIPT_AREA_ID { get; set; }
        public decimal COUNTRY_AREA_ID { get; set; }
        public decimal CARGO_PROPERTY { get; set; }
        public decimal? FEETYPE_ID { get; set; }
        public decimal? UNIT { get; set; }
        public string PPCC { get; set; }
        public string CURRENCY { get; set; }
        public decimal? BOOKING_COST { get; set; }
        public decimal? GP20_COST { get; set; }
        public decimal? GP40_COST { get; set; }
        public decimal? HQ40_COST { get; set; }
        public decimal? GP45_COST { get; set; }
        public decimal? BOOKING_SALE { get; set; }
        public decimal? GP20_SALE { get; set; }
        public decimal? GP40_SALE { get; set; }
        public decimal? HQ40_SALE { get; set; }
        public decimal? GP45_SALE { get; set; }
        public DateTime? EFFECTIVE_DATE { get; set; }
        public DateTime? EXPIRATION_DATE { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_USER_NAME { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
        public string RECEIPT_AREA_CNAME { get; set; }
        public string RECEIPT_AREA_ENAME { get; set; }
        public string COUNTRY_AREA_CNAME { get; set; }
        public string COUNTRY_AREA_ENAME { get; set; }
    }
}
