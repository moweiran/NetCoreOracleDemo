using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class BOOKING_ORDER_SI
    {
        public decimal BOOKING_ORDER_SI_ID { get; set; }
        public decimal BOOKING_ORDER_ID { get; set; }
        public decimal MAIN_BOOKING_ORDER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CUSTOMER_TYPE { get; set; }
        public decimal? CUSTOMER_ID { get; set; }
        public decimal? CUSTOMER_COMPANY_ID { get; set; }
        public string BOOKING_NO { get; set; }
        public string SI_NO { get; set; }
        public string BL_TYPE { get; set; }
        public string RELEASE_MODE { get; set; }
        public string TRANS_TYPE_CODE { get; set; }
        public string TRADETERMS_CODE { get; set; }
        public string PPCC { get; set; }
        public string PAY_LOCATION { get; set; }
        public string SHIPPER_DESC { get; set; }
        public string CONSIGNEE_DESC { get; set; }
        public string NOTIFIER_DESC { get; set; }
        public string FORWARDING_DESC { get; set; }
        public string CARGO_DESC { get; set; }
        public string MARKS { get; set; }
        public decimal? WEIGHT { get; set; }
        public string WEIGHT_UNIT { get; set; }
        public decimal? CBM { get; set; }
        public decimal? PICS { get; set; }
        public string PICS_UNIT { get; set; }
        public string SI_REMARK { get; set; }
        public string CONTA_DESC { get; set; }
        public decimal STATUS { get; set; }
        public decimal? SUBMIT_USERID { get; set; }
        public string SUBMIT_FULLNAME { get; set; }
        public DateTime? SUBMIT_DATE { get; set; }
        public decimal? APPROVED_ID { get; set; }
        public string APPROVED_FULLNAME { get; set; }
        public DateTime? APPROVED_DATE { get; set; }
        public string APPROVED_OPINION { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
