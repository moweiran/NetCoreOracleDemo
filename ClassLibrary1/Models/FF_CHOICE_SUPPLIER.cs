using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_CHOICE_SUPPLIER
    {
        public decimal CHOICE_SUPPLIER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string FF_SHORTNAME { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public string FF_COMPANY_SHORTNAME { get; set; }
        public decimal CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public decimal? SHIP_ROUTE_AREA_ID { get; set; }
        public string SHIP_ROUTE_AREA_CODE { get; set; }
        public string SHIP_ROUTE_AREA_NAME { get; set; }
        public decimal ROUTE_ID { get; set; }
        public string ROUTE_CODE { get; set; }
        public string ROUTE_NAME { get; set; }
        public decimal SUPPLIER_ID { get; set; }
        public string SUPPLIER_SHORTNAME { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal SUPPLIER_COMPANY_ID { get; set; }
        public string SUPPLIER_COMPANY_SHORTNAME { get; set; }
    }
}
