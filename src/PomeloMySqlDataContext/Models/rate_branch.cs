using System;
using System.Collections.Generic;

namespace PomeloMySqlDataContext.Models
{
    public partial class rate_branch
    {
        public long RATE_BRANCH_ID { get; set; }
        public string SHIP_BRANCH_RATE_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public long ROUTE_ID { get; set; }
        public long MAINPORT_ID { get; set; }
        public int BUSINESS_TYPE { get; set; }
        public long BRANCHPORT_ID { get; set; }
        public decimal? GP20 { get; set; }
        public decimal? GP40 { get; set; }
        public decimal? HQ40 { get; set; }
        public decimal? GP45 { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime EXPIRATION_DATE { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
