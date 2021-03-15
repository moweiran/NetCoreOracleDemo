using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class BOOKING_ORDER_AGENCY_CHARGE
    {
        public decimal BOOKING_ORDER_AGENCY_CHARGE_ID { get; set; }
        public decimal BOOKING_ORDER_ID { get; set; }
        public decimal BOOKING_ORDER_RATE_ID { get; set; }
        public decimal BUSINESS_TYPE { get; set; }
        public decimal SERVICE_PROJECT { get; set; }
        public decimal FEETYPE_ID { get; set; }
        public decimal UNIT { get; set; }
        public string CONTA_SIZETYPE_CODE { get; set; }
        public decimal COST { get; set; }
        public decimal PRICE { get; set; }
        public decimal QTY { get; set; }
        public decimal AMOUNT { get; set; }
        public string CURRENCY { get; set; }
        public string REMARK { get; set; }
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
    }
}
