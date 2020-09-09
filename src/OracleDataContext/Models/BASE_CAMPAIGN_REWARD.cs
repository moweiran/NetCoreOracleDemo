using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BASE_CAMPAIGN_REWARD
    {
        public decimal BASE_CAMPAIGN_REWARD_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string REWARD_NO { get; set; }
        public decimal COMPANY_ID { get; set; }
        public decimal REWARD_TYPE { get; set; }
        public decimal SEED_LEVEL { get; set; }
        public decimal APPLY_AMOUNT { get; set; }
        public decimal APPLY_USERID { get; set; }
        public string APPLY_FULLNAME { get; set; }
        public DateTime? APPLY_DATE { get; set; }
        public string RECEIVABLE_NO { get; set; }
        public string APPLY_REMARK { get; set; }
        public decimal? PAY_AMOUNT { get; set; }
        public decimal? PAY_USERID { get; set; }
        public string PAY_FULLNAME { get; set; }
        public DateTime? PAY_DATE { get; set; }
        public string PAY_NO { get; set; }
        public string PAY_REMARK { get; set; }
        public decimal STATUS { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
        public string REMARK { get; set; }
    }
}
