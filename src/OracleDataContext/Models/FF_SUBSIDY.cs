using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_SUBSIDY
    {
        public decimal FF_SUBSIDY_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FCL_TOTAL_AMOUN { get; set; }
        public decimal FCL_USE_AMOUNT { get; set; }
        public decimal FCL_FROZEN_AMOUNT { get; set; }
        public decimal FCL_SURPLUS_AMOUNT { get; set; }
        public decimal FCL_PLATFORM_AMOUNT { get; set; }
        public decimal FCL_REFEREE_AMOUNT { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
