using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_WRITE_OFF
    {
        public decimal FF_WRITE_OFF_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string WRITE_OFF_NO { get; set; }
        public string CURRENCY { get; set; }
        public decimal RECEIVER_COMPANY_TYPE { get; set; }
        public decimal RECEIVER_COMPANY_ID { get; set; }
        public decimal? RECEIVER_SUB_COMPANY_ID { get; set; }
        public string RECEIVER_COMPANY_CODE { get; set; }
        public string RECEIVER_COMPANY_ENAME { get; set; }
        public string RECEIVER_COMPANY_CNAME { get; set; }
        public decimal PAY_COMPANY_TYPE { get; set; }
        public decimal PAY_COMPANY_ID { get; set; }
        public decimal? PAY_SUB_COMPANY_ID { get; set; }
        public string PAY_COMPANY_CODE { get; set; }
        public string PAY_COMPANY_ENAME { get; set; }
        public string PAY_COMPANY_CNAME { get; set; }
        public decimal? PAY_AMOUNT { get; set; }
        public DateTime? PAY_DATE { get; set; }
        public decimal? PAY_BANKACCOUNT_ID { get; set; }
        public decimal? RECEIVER_AMOUNT { get; set; }
        public DateTime? RECEIVER_DATE { get; set; }
        public decimal? RECEIVER_BANKACCOUNT_ID { get; set; }
        public decimal? BANK_POUNDAGE { get; set; }
        public decimal? GAINS_LOSSES { get; set; }
        public decimal PAY_BILL_AMOUNT { get; set; }
        public decimal RECEIVER_BILL_AMOUNT { get; set; }
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
