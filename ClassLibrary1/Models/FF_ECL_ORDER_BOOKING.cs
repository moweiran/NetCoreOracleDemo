using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_ECL_ORDER_BOOKING
    {
        public decimal FF_ECL_ORDER_BOOKING_ID { get; set; }
        public decimal FF_ECL_ORDER_ID { get; set; }
        public decimal MAIN_ORDER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string RECEIPT_WAREHOUSE { get; set; }
        public string RECEIPT_WAREHOUSE_ADDRESS { get; set; }
        public string RECEIPT_WAREHOUSE_TEL { get; set; }
        public decimal? CONFIRM_WEIGHT { get; set; }
        public decimal? CONFIRM_CBM { get; set; }
        public decimal? CONFIRM_USERID { get; set; }
        public string CONFIRM_FULLNAME { get; set; }
        public DateTime? CONFIRM_DATE { get; set; }
        public string CONFIRM_REMARK { get; set; }
        public decimal? TRANSPORT_COMPANY_TYPE { get; set; }
        public decimal? TRANSPORT_COMPANY_ID { get; set; }
        public string TRANSPORT_COMPANY_CODE { get; set; }
        public string TRANSPORT_COMPANY_CNAME { get; set; }
        public string TRANSPORT_COMPANY_ENAME { get; set; }
        public string TRANSPORT_NO { get; set; }
        public string TRANSPORT_CLASS { get; set; }
        public string CONTAINER_NO { get; set; }
        public DateTime? ETD { get; set; }
        public DateTime? ETA { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? CONFIRM_CHARGE_QTY { get; set; }
        public string BOOKING_NO { get; set; }
        public decimal? AFTER_EXPRESS_ID { get; set; }
        public string AFTER_EXPRESS_NO { get; set; }
        public decimal? MAINLINE_ORDER_ID { get; set; }
        public string MAINLINE_ORDER_NO { get; set; }
        public decimal? SHIPROCKET_STATUS { get; set; }
        public decimal? MAINLINE_TYPE { get; set; }
    }
}
