using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_AGENCY_CHARGES
    {
        public decimal AGENCY_CHARGES_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal BUSINESS_TYPE { get; set; }
        public decimal SERVICE_PROJECT { get; set; }
        public decimal CHARGE_SOURCE { get; set; }
        public decimal COUNTRY_ID { get; set; }
        public decimal PROVINCE_ID { get; set; }
        public decimal CITY_ID { get; set; }
        public decimal? PORT_ID { get; set; }
        public decimal? SUPPLIER_TYPE { get; set; }
        public decimal? SUPPLIER_ID { get; set; }
        public decimal? COST_CUSTOMER_ID { get; set; }
        public string CARGO_PROPERTY_CODE { get; set; }
        public decimal FEETYPE_ID { get; set; }
        public string PPCC { get; set; }
        public string CURRENCY { get; set; }
        public decimal UNIT { get; set; }
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
        public bool? IS_ACTUAL_COST_PAY { get; set; }
        public DateTime? EXPIRATION_DATE { get; set; }
        public DateTime? EFFECTIVE_DATE { get; set; }
        public bool? IS_APPLY_DIRECTCUSTOMER { get; set; }
        public bool? IS_APPLY_PEER { get; set; }
        public bool? IS_APPLY_OVERSEAAGENCY { get; set; }
        public string REMARK { get; set; }
        public decimal STATUS { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_USER_NAME { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
        public bool? IS_MUST_CHARGE { get; set; }
    }
}
