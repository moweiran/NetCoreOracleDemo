using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BASE_PARTNER_REWARD
    {
        public string BASE_PARTNER_REWARD_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal COMPANY_ID { get; set; }
        public decimal YEARS { get; set; }
        public decimal MONTHS { get; set; }
        public decimal DIRECT_CUSTOMER_TEU { get; set; }
        public decimal PEER_CUSTOMER_TEU { get; set; }
        public decimal TOTAL_TEU { get; set; }
        public decimal MONTH_BILL_AMOUNT { get; set; }
        public decimal COMMISSION_PROPORTION { get; set; }
        public decimal COMMISSION_AMOUNT { get; set; }
        public string BANK_NAME { get; set; }
        public string BANK_ACCOUNTNO { get; set; }
        public decimal? PAY_AMOUNT { get; set; }
        public DateTime? PAY_DATE { get; set; }
        public string PAY_NO { get; set; }
        public string PAY_REMARK { get; set; }
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
