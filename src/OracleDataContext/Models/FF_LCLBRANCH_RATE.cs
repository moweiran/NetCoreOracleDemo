using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_LCLBRANCH_RATE
    {
        public decimal FF_LCLBRANCH_RATE_ID { get; set; }
        public decimal FF_LCLBRANCH_RATES_LIST_ID { get; set; }
        public decimal FF_LCLBRANCH_PRODUCT_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal PORT_ID { get; set; }
        public decimal PORT_CITY_ID { get; set; }
        public decimal LOCATION_ID { get; set; }
        public decimal LOCATION_CITY_ID { get; set; }
        public decimal? LOCATION_PROVINCE_ID { get; set; }
        public string CURRENCY { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public decimal? RATE { get; set; }
        public decimal? MIN_CBM { get; set; }
        public decimal STATUS { get; set; }
        public string REMARK { get; set; }
        public DateTime RATE_UPDATEDATE { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
