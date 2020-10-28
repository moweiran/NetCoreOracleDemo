using System;
using System.Collections.Generic;

namespace PomeloMySqlDataContext.Models
{
    public partial class port_change_fee
    {
        public long PORT_CHANGE_FEE_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public long CARRIER_COMPANY_ID { get; set; }
        public long ROUTE_ID { get; set; }
        public string ROUTE_CODE { get; set; }
        public long POL_ID { get; set; }
        public int? FREE_CHANGE_TIME { get; set; }
        public decimal? CHANGE_FEE { get; set; }
        public decimal? CANCEL_PRE_FEE { get; set; }
        public decimal? CANCEL_AFTER_FEE { get; set; }
        public decimal? CANCEL_CLOSE_FEE { get; set; }
        public int? STEADY_TEU { get; set; }
        public int? CONFIRM_STEADY_TEU { get; set; }
        public string REMARK { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
