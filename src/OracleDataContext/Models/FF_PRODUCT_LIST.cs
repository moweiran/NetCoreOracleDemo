using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_PRODUCT_LIST
    {
        public decimal FF_PRODUCT_LIST_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public decimal? SHIP_ROUTE_AREA_ID { get; set; }
        public decimal ROUTE_ID { get; set; }
        public string ROUTE_CODE { get; set; }
        public string ROUTE_NAME { get; set; }
        public decimal? COURSE { get; set; }
        public decimal? PRODUCT_COUNT { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? CONTACT_USERID { get; set; }
        public string CONTACT_NAME { get; set; }
        public string CONTACT_TEL { get; set; }
        public string CONTACT_MOBILE { get; set; }
        public string CONTACT_EMAIL { get; set; }
        public string CONTACT_QQ { get; set; }
        public decimal PRODUCTS_TYPE { get; set; }
        public string PRODUCT_NAME { get; set; }
        public string CONTACT_WX { get; set; }
    }
}
