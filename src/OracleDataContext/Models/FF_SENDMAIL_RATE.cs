using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_SENDMAIL_RATE
    {
        public decimal FF_SENDMAIL_RATE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_RATE_CUSTOMER_ID { get; set; }
        public decimal PRODUCT_ID { get; set; }
        public decimal FF_MAIL_INFO_ID { get; set; }
        public string SEND_MAIL { get; set; }
        public string CARRIER_CODE { get; set; }
        public string ROUTE_CODE { get; set; }
        public decimal? RECEIPT_ID { get; set; }
        public decimal? POL_ID { get; set; }
        public decimal? POD_ID { get; set; }
        public decimal? DELIVERY_ID { get; set; }
        public decimal SCHEDULE_ID { get; set; }
        public string VESSEL_NAME { get; set; }
        public string VOYAGE { get; set; }
        public decimal STATUS { get; set; }
        public string REMARK { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public string TO_MAIL { get; set; }
        public DateTime? SEND_DATE { get; set; }
        public string MAIL_SUBJECT { get; set; }
        public string MAIL_CONTENT { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_USER_NAME { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
        public decimal? CARRIER_ID { get; set; }
    }
}
