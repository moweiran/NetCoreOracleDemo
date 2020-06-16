using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class BOOKING_ORDER_RATE
    {
        public BOOKING_ORDER_RATE()
        {
            BOOKING_ORDER_FREEDETENTION = new HashSet<BOOKING_ORDER_FREEDETENTION>();
        }

        public decimal BOOKING_ORDER_RATE_ID { get; set; }
        public decimal BOOKING_ORDER_ID { get; set; }
        public decimal PARENT_BOOKING_RATE_ID { get; set; }
        public decimal RATE_TYPE { get; set; }
        public decimal? CONTA_PROPERTY { get; set; }
        public string CONTA_SIZETYPE_CODE { get; set; }
        public string CARGO_PROPERTY { get; set; }
        public decimal? DANGEROU_LEVEL_ID { get; set; }
        public string DANGEROU_LEVEL_CODE { get; set; }
        public decimal CONTA_QTY { get; set; }
        public decimal TEU { get; set; }
        public decimal? CONTA_WEIGHT { get; set; }
        public string CURRENCY { get; set; }
        public decimal? RATE_COST { get; set; }
        public decimal RATE_CUSTOMER { get; set; }
        public decimal? RATE_CUSTOMER_REQUEST { get; set; }
        public decimal? RATE_CUSTOMER_REPLY { get; set; }
        public decimal RATE_FINAL { get; set; }
        public string CARGO_DESC { get; set; }
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
        public decimal MAIN_BOOKING_RATE_ID { get; set; }
        public string CONTA_SIZE { get; set; }
        public decimal? SURCHARGE_TYPE { get; set; }
        public decimal? SURCHARGE_AMOUNT { get; set; }
        public decimal? RATE_SALES_COST { get; set; }
        public decimal? EIR_QTY { get; set; }

        public virtual BOOKING_ORDER BOOKING_ORDER_ { get; set; }
        public virtual ICollection<BOOKING_ORDER_FREEDETENTION> BOOKING_ORDER_FREEDETENTION { get; set; }
    }
}
