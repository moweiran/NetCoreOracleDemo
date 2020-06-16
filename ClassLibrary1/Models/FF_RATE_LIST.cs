using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_RATE_LIST
    {
        public decimal FF_RATE_LIST_ID { get; set; }
        public decimal FF_PRODUCT_LIST_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal RATE_SOURCE { get; set; }
        public decimal? SUPPLIER_ID { get; set; }
        public decimal CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public decimal? SHIP_ROUTE_AREA_ID { get; set; }
        public decimal ROUTE_ID { get; set; }
        public string ROUTE_CODE { get; set; }
        public string ROUTE_NAME { get; set; }
        public decimal? COURSE { get; set; }
        public decimal SCHEDULE_ID { get; set; }
        public string VESSEL_CODE { get; set; }
        public string VESSEL_NAME_CN { get; set; }
        public string VESSEL_NAME_EN { get; set; }
        public string VOYAGE { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public DateTime RATE_UPDATEDATE { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal STATUS { get; set; }
        public decimal SCHEDULE_TYPE { get; set; }
        public decimal? POL_ID { get; set; }
    }
}
