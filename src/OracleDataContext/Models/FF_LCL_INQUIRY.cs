using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_LCL_INQUIRY
    {
        public decimal FF_LCL_INQUIRY_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string INQUIRY_NO { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal RECEIPT_ID { get; set; }
        public decimal RECEIPT_CITY_ID { get; set; }
        public decimal DELIVERY_ID { get; set; }
        public decimal DELIVERY_CITY_ID { get; set; }
        public decimal SHIP_ROUTE_AREA_ID { get; set; }
        public DateTime? PLAN_DATE { get; set; }
        public decimal? CARGO_WEIGHT { get; set; }
        public decimal? CARGO_VOLUME { get; set; }
        public string CARGO_DESC { get; set; }
        public decimal STATUS { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
