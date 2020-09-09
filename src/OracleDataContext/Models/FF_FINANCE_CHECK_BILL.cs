using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_FINANCE_CHECK_BILL
    {
        public decimal FF_FINANCE_CHECK_BILL_ID { get; set; }
        public decimal FF_FINANCE_CHECK_ID { get; set; }
        public decimal FF_BILL_LIST_ID { get; set; }
        public decimal BILL_WAY { get; set; }
        public decimal FF_ID { get; set; }
        public string CURRENCY { get; set; }
        public decimal? AMOUNT { get; set; }
        public decimal? RATE { get; set; }
        public decimal? FINAL_AMOUNT { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USER_ID { get; set; }
        public string CREATE_USER_NAME { get; set; }
        public string CREATE_FULL_NAME { get; set; }
        public DateTime CREATE_DATE_TIME { get; set; }
    }
}
