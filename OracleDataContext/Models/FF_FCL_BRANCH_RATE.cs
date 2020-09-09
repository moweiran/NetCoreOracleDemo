using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_FCL_BRANCH_RATE
    {
        public decimal FF_FCL_BRANCH_RATE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string BRANCH_RATE_ID { get; set; }
        public decimal CARRIER_ID { get; set; }
        public decimal ROUTE_ID { get; set; }
        public decimal PORT_ID { get; set; }
        public decimal BUSINESS_TYPE { get; set; }
        public decimal? GP20 { get; set; }
        public decimal? GP40 { get; set; }
        public decimal? HQ40 { get; set; }
        public decimal? GP45 { get; set; }
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
