using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_MONTHLY_BILL
    {
        public decimal FF_MONTHLY_BILL_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal BILL_YEAR { get; set; }
        public decimal BILL_MONTHLY { get; set; }
        public decimal AMOUNT_SERVICECHARGE { get; set; }
        public decimal AMOUNT_INTEREST { get; set; }
        public decimal AMOUNT_WAY { get; set; }
        public decimal AMOUNT_BALANCE { get; set; }
        public string PAY_INFO_ID { get; set; }
        public string PAY_FULLNAME { get; set; }
        public DateTime? PAY_DATE { get; set; }
        public string PAY_REMARK { get; set; }
        public decimal STATUS { get; set; }
        public string REMARK { get; set; }
        public DateTime LAST_PAY_DATE { get; set; }
        public decimal? MONTHLY_BILL_CASH_ID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
    }
}
