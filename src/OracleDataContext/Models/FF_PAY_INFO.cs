using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_PAY_INFO
    {
        public string FF_PAY_INFO_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal BUSINESS_TYPE { get; set; }
        public string BILL_LIST_ID { get; set; }
        public decimal AMOUNT { get; set; }
        public decimal STATUS { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public DateTime? PAY_DATE { get; set; }
        public string PAY_SYSTEM_ID { get; set; }
        public string REMARK { get; set; }
        public decimal? PAY_TYPE { get; set; }
        public decimal? AMOUNT_BILL { get; set; }
        public decimal? AMOUNT_INSURANCE { get; set; }
        public decimal? AMOUNT_LOAN { get; set; }
        public decimal? AMOUNT_INTEREST { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? AMOUNT_SERVICEFEE { get; set; }
        public decimal? THUNES_PAYMENT_ID { get; set; }
    }
}
