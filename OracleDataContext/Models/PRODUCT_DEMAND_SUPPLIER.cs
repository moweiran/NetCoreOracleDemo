using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class PRODUCT_DEMAND_SUPPLIER
    {
        public decimal PRODUCT_DEMAND_SUPPLIER_ID { get; set; }
        public decimal PRODUCT_DEMAND_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public decimal? SHIP_ROUTE_AREA_ID { get; set; }
        public decimal ROUTE_ID { get; set; }
        public string ROUTE_CODE { get; set; }
        public string ROUTE_NAME { get; set; }
        public string PRODUCT_NO { get; set; }
        public decimal? TT { get; set; }
        public decimal? TOTAL_TEU { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? RECEIPT_ID { get; set; }
        public decimal? DELIVERY_ID { get; set; }
        public bool? VALID { get; set; }
        public decimal CUSTOMER_TYPE { get; set; }
        public decimal FF_CUSTOMER_ID { get; set; }
        public decimal PRODUCT_ID { get; set; }
        public decimal? LAND_PRODUCT_PATH_ID { get; set; }
        public decimal PRODUCT_TYPE { get; set; }
        public decimal CLOSE { get; set; }
        public decimal DEPARTURE { get; set; }
        public decimal? POL_ID { get; set; }
        public decimal? POD_ID { get; set; }

        public virtual PRODUCT_DEMAND PRODUCT_DEMAND_ { get; set; }
    }
}
