using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_BILL
    {
        public decimal FF_BILL_ID { get; set; }
        public decimal MAIN_BOOKING_ORDER_ID { get; set; }
        public decimal BOOKING_ORDER_ID { get; set; }
        public decimal? MAIN_BILL_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal RECEIVER_COMPANY_TYPE { get; set; }
        public decimal RECEIVER_COMPANY_ID { get; set; }
        public decimal PAY_COMAPNY_TYPE { get; set; }
        public decimal PAY_COMPANY_ID { get; set; }
        public decimal FEETYPE_ID { get; set; }
        public decimal PRICE { get; set; }
        public decimal QTY { get; set; }
        public decimal AMOUNT { get; set; }
        public string CURRENCY { get; set; }
        public string CONTA_SIZETYPE_CODE { get; set; }
        public decimal STATUS { get; set; }
        public decimal DATA_SOURCE { get; set; }
        public decimal? DATE_REF_ID { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_USER_NAME { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
        public decimal? PARENT_BILL_ID { get; set; }
        public decimal? VERIFY_USERID { get; set; }
        public string VERIFY_FULLNAME { get; set; }
        public DateTime? VERIFY_DATE { get; set; }
        public string VERIFY_OPINION { get; set; }
        public decimal FF_BILL_LIST_ID { get; set; }
        public decimal? PRESALE_ORDER_ID { get; set; }
        public string PAYMENT_CURRENCY { get; set; }
        public decimal? RATE { get; set; }
        public decimal? PAYMENT_AMOUNT { get; set; }
    }
}
