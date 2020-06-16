using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_RTFCL_ORDER_BOOKING
    {
        public decimal FF_RTFCL_ORDER_BOOKING_ID { get; set; }
        public decimal FF_RTFCL_ORDER_ID { get; set; }
        public decimal MAIN_ORDER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal? CONFIRM_USERID { get; set; }
        public string CONFIRM_FULLNAME { get; set; }
        public DateTime? CONFIRM_DATE { get; set; }
        public decimal? TRANSPORT_COMPANY_ID { get; set; }
        public string TRANSPORT_COMPANY_CODE { get; set; }
        public string TRANSPORT_COMPANY_CNAME { get; set; }
        public string TRANSPORT_COMPANY_ENAME { get; set; }
        public string BOOKING_NO { get; set; }
        public string TRANSPORT_NO { get; set; }
        public string TRANSPORT_CLASS { get; set; }
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
    }
}
