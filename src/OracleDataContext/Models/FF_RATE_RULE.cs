using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_RATE_RULE
    {
        public decimal FF_RATE_RULE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CARRIER_ID { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal ROUTE_ID { get; set; }
        public decimal? PEER_GP20 { get; set; }
        public decimal? PEER_GP40 { get; set; }
        public decimal? PEER_HQ40 { get; set; }
        public decimal? PEER_GP45 { get; set; }
        public decimal? PEER_VIP_GP20 { get; set; }
        public decimal? PEER_VIP_GP40 { get; set; }
        public decimal? PEER_VIP_HQ40 { get; set; }
        public decimal? PEER_VIP_GP45 { get; set; }
        public decimal? SALES_GP20 { get; set; }
        public decimal? SALES_GP40 { get; set; }
        public decimal? SALES_HQ40 { get; set; }
        public decimal? SALES_GP45 { get; set; }
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
