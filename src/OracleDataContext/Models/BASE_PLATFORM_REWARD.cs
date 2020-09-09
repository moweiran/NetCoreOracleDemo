using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BASE_PLATFORM_REWARD
    {
        public decimal BASE_PLATFORM_REWARD_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string ADVANTAGE_CARRIER { get; set; }
        public string ADVANTAGE_ROUTE { get; set; }
        public decimal? APPLY_USERID { get; set; }
        public string APPLY_FULLNAME { get; set; }
        public DateTime? APPLY_DATE { get; set; }
        public string APPLY_REMARK { get; set; }
        public decimal? CHECK_USERID { get; set; }
        public string CHEDK_FULLNAME { get; set; }
        public DateTime? CHECK_DATE { get; set; }
        public string CHECK_REMARK { get; set; }
        public decimal? AMOUNT { get; set; }
        public decimal STATUS { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
