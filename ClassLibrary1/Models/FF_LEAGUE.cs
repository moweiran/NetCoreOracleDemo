using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_LEAGUE
    {
        public decimal FF_LEAGUE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string FF_SHORTNAME { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public string FF_COMPANY_SHORTNAME { get; set; }
        public decimal CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public string CUSTOMER_SHORTNAME { get; set; }
        public decimal ROUTE_AREA_ID { get; set; }
        public string ROUTE_AREA_NAME_CN { get; set; }
        public string ROUTE_AREA_NAME_EN { get; set; }
        public decimal? ROUTE_ID { get; set; }
        public string ROUTE_CODE { get; set; }
        public string ROUTE_NAME { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
