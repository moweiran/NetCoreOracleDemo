using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_CARRIER_CONTRACT
    {
        public decimal FF_CARRIER_CONTRACT_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string CARRIER_IDS { get; set; }
        public decimal STATUS { get; set; }
        public string REMARK { get; set; }
        public DateTime? CHECK_DATE { get; set; }
        public string CHECK_REMARK { get; set; }
        public bool DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
