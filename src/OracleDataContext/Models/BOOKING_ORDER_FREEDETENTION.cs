using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class BOOKING_ORDER_FREEDETENTION
    {
        public decimal BOOKING_ORDER_FREEDETENTION_ID { get; set; }
        public decimal BOOKING_ORDER_RATE_ID { get; set; }
        public decimal BOOKING_ORDER_ID { get; set; }
        public decimal MAIN_BOOKING_ORDER_ID { get; set; }
        public decimal? RECEIPT_ID { get; set; }
        public decimal? RECEIPT_FREEDETENTION_DEFAULT { get; set; }
        public decimal? RECEIPT_FREEDETENTION_REQUEST { get; set; }
        public decimal? RECEIPT_FREEDETENTION_REPLY { get; set; }
        public decimal? RECEIPT_FREEDETENTION_FINAL { get; set; }
        public decimal? RECEIPT_FREEDEMURRAGE_DEFAULT { get; set; }
        public decimal? RECEIPT_FREEDEMURRAGE_REQUEST { get; set; }
        public decimal? RECEIPT_FREEDEMURRAGE_REPLY { get; set; }
        public decimal? RECEIPT_FREEDEMURRAGE_FINAL { get; set; }
        public decimal? DELIVERY_ID { get; set; }
        public decimal? DELIVERY_FREEDETENTION_DEFAULT { get; set; }
        public decimal? DELIVERY_FREEDETENTION_REQUEST { get; set; }
        public decimal? DELIVERY_FREEDETENTION_REPLY { get; set; }
        public decimal? DELIVERY_FREEDETENTION_FINAL { get; set; }
        public decimal? DELIVERY_FREEDEMURRAGE_DEFAULT { get; set; }
        public decimal? DELIVERY_FREEDEMURRAGE_REQUEST { get; set; }
        public decimal? DELIVERY_FREEDEMURRAGE_REPLY { get; set; }
        public decimal? DELIVERY_FREEDEMURRAGE_FINAL { get; set; }
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

        public virtual BOOKING_ORDER_RATE BOOKING_ORDER_RATE { get; set; }
    }
}
