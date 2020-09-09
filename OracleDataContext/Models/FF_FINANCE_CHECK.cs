using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_FINANCE_CHECK
    {
        public decimal FF_FINANCE_CHECK_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal CHECK_WAY { get; set; }
        public string CHECK_NO { get; set; }
        public string CURRENCY { get; set; }
        public decimal BALANCE_COMPANY_TYPE { get; set; }
        public decimal BALANCE_COMPANY_ID { get; set; }
        public string BALANCE_COMPANY_CODE { get; set; }
        public string BALANCE_COMPANY_ENAME { get; set; }
        public string BALANCE_COMPANY_CNAME { get; set; }
        public DateTime CHECK_DATE { get; set; }
        public decimal? CHECK_AMOUNT { get; set; }
        public decimal? BANKACCOUNT_ID { get; set; }
        public DateTime? BANK_DATE { get; set; }
        public decimal TOTAL_BILL_AMOUNT { get; set; }
        public decimal TOTAL_EXPENSES_AMOUNT { get; set; }
        public string REMARK { get; set; }
        public decimal STATUS { get; set; }
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
