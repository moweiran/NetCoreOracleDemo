using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_FCL_LAND_RATE
    {
        public decimal FF_FCL_LAND_RATE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal LAND_FEE_ID { get; set; }
        public decimal LAND_FEE_PRICE_ID { get; set; }
        public decimal LAND_FEE_DETAIL_ID { get; set; }
        public decimal LAND_FEE_ROUTE_ID { get; set; }
        public decimal CARRIER_ID { get; set; }
        public decimal ROUTE_ID { get; set; }
        public decimal PORT_ID { get; set; }
        public decimal ADAPT_TO { get; set; }
        public decimal? GP20 { get; set; }
        public decimal? GP20_DOUBLE { get; set; }
        public decimal? GP40 { get; set; }
        public decimal? GP45 { get; set; }
        public decimal STATUS { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
