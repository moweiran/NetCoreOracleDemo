﻿using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_PRODUCT_SURCHARGES
    {
        public decimal FF_PRODUCT_SURCHARGE_ID { get; set; }
        public decimal SURCHARGE_TYPE { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal CARRIER_ID { get; set; }
        public decimal PRODUCT_ID { get; set; }
        public decimal DATA_SOURCE { get; set; }
        public decimal? SHIP_SURCHARGE_ID { get; set; }
        public string CARGO_PROPERTY { get; set; }
        public decimal FEETYPE_ID { get; set; }
        public decimal UNIT { get; set; }
        public string PPCC { get; set; }
        public string CURRENCY { get; set; }
        public decimal? BOOKING_COST { get; set; }
        public decimal? GP20_COST { get; set; }
        public decimal? GP40_COST { get; set; }
        public decimal? HQ40_COST { get; set; }
        public decimal? GP45_COST { get; set; }
        public decimal? BOOKING_ADD { get; set; }
        public decimal? GP20_ADD { get; set; }
        public decimal? GP40_ADD { get; set; }
        public decimal? HQ40_ADD { get; set; }
        public decimal? GP45_ADD { get; set; }
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
        public decimal? FF_AREA_SURCHARGE_ID { get; set; }
        public decimal PRODUCT_SOURCE { get; set; }
        public decimal? FF_FCLSURCHARGE_ID { get; set; }
    }
}
